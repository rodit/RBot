using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RBot
{
	public partial class JumpForm : HideForm
	{
		private string _lastMap = "";

		public JumpForm()
		{
			InitializeComponent();
			GotFocus += UpdateCells;
			cbCell.GotFocus += UpdateCells;

			UpdateCustomTravels();

			foreach (Button b in Enumerable.Range(0, grpFastTravel.Controls.Count).Select(i => grpFastTravel.Controls[i]).Where(c => c is Button))
			{
				if (b.Tag != null)
					b.Click += async (s, e) => await Travel(((string)b.Tag).Split(','));
			}
		}

		private async Task Travel(string[] travel)
		{
			if (!Bot.Player.LoggedIn)
				return;
				if (travel.Length == 3 && travel[0] == "tercessuinotlim")
					await Task.Run(() => JoinTercess(travel[1], travel[2], ModifierKeys == Keys.Control));
				else if (travel.Length == 3)
					await Task.Run(() => Join(travel[0], travel[1], travel[2], ModifierKeys == Keys.Control));
		}

		private void Join(string map, string cell, string pad, bool privateRoom)
			=> Bot.Player.Join(privateRoom ? $"{map}-111111" : map, cell, pad);

		private void JoinTercess(string cell = "Enter", string pad = "Spawn", bool privateRoom = false)
		{
			if(Bot.Map.Name == "tercessuinotlim")
				Bot.Player.Jump(cell, pad);
			else
			{
				Bot.Player.Jump("m22", "Left");
				Bot.Player.Join(privateRoom ? "tercessuinotlim-111111" : "tercessuinotlim", cell, pad);
			}
		}

		private void UpdateCells(object sender, EventArgs e)
		{
			if (Bot.Player.LoggedIn)
			{
				string map = Bot.Map.Name;
				if (map != null && _lastMap != map)
				{
					cbCell.Items.Clear();
					cbCell.Items.AddRange(Bot.Map.Cells.ToArray());
					_lastMap = map;
				} 
			}
		}

		private void btnGetCurrent_Click(object sender, EventArgs e)
		{
			if (ModifierKeys == Keys.Shift)
				Clipboard.SetText($"\"{Bot.Map.Name}\", \"{Bot.Player.Cell}\", \"{Bot.Player.Pad}\"");
			else if (ModifierKeys == Keys.Control)
				Clipboard.SetText($"\"{Bot.Player.Cell}\", \"{Bot.Player.Pad}\"");
			else
			{
				UpdateCells(sender, e);
				cbCell.SelectedItem = Bot.Player.Cell;
				cbPads.SelectedItem = Bot.Player.Pad;
			}
		}

		private async void btnJump_Click(object sender, EventArgs e)
		{
			if (cbCell.SelectedIndex > -1 && cbPads.SelectedIndex > -1)
			{
				string cell = cbCell.SelectedItem as string;
				string pad = cbPads.SelectedItem as string;
				await Task.Run(() => Bot.Player.Jump(cell, pad));
			}
		}

		private void UpdateCustomTravels()
		{
			cbCustomTravels.Items.Clear();
			CustomTravelObj[] travels = GetCustomTravels();
			if (travels != null)
            {
				cbCustomTravels.Items.AddRange(travels);            
				cbCustomTravels.SelectedIndex = -1;
            }
		}

		private CustomTravelObj[] GetCustomTravels()
		{
			string[] travels = AppRuntime.Options.Get<string>("travel")?.Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
			if (travels == null)
				return null;
			List<CustomTravelObj> list = new List<CustomTravelObj>();
			foreach (string travel in travels)
			{
				string[] splitted = travel.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
				list.Add(new CustomTravelObj(splitted[0], splitted.Skip(1).ToArray()));
			}
			return list.ToArray();
		}

		private void btnAddTravel_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtAddTravel.Text))
				return;
			string[] input = txtAddTravel.Text.Replace("\"", "").Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(s => s.Trim()).ToArray();
			switch(input.Length)
			{
				case 1:
					AddCustomTravels(input[0], input[0]);
					break;
				case 2:
					AddCustomTravels(input[0], input[1]);
					break;
				case 3:
					AddCustomTravels(input[0], input[0], input[1], input[2]);
					break;
				case 4:
					AddCustomTravels(input[0], input[1], input[2], input[3]);
					break;
			}
			UpdateCustomTravels();
		}

		private void AddCustomTravels(string display, string map, string cell = "Enter", string pad = "Spawn")
		{
			string currentCT = AppRuntime.Options.Get<string>("travel") ?? "";
			AppRuntime.Options.Set("travel", $"{currentCT}{display},{map},{cell},{pad}|");
		}

		private void RemoveCustomTravels(CustomTravelObj ct)
		{
			string savedCT = AppRuntime.Options.Get<string>("travel") ?? "";
			if (!string.IsNullOrWhiteSpace(savedCT))
			{
				string toRemove = $"{ct.Display},{ct.TravelCommand[0]},{ct.TravelCommand[1]},{ct.TravelCommand[2]}|";
				AppRuntime.Options.Set("travel", savedCT.Replace(toRemove, ""));
				UpdateCustomTravels();
			}
		}

		private async void btnTravelCustom_Click(object sender, EventArgs e)
		{
			if (cbCustomTravels.SelectedIndex < 0 || cbCustomTravels.SelectedItem == null)
				return;
			if (ModifierKeys == Keys.Alt)
				RemoveCustomTravels((CustomTravelObj)cbCustomTravels.SelectedItem);
			else
				await Travel(((CustomTravelObj)cbCustomTravels.SelectedItem).TravelCommand);
		}

        class CustomTravelObj
        {
            public CustomTravelObj(string display, string[] command)
            {
                Display = display;
                TravelCommand = command;
            }
            public string Display { get; set; } = "Battleon";
            public string[] TravelCommand { get; set; } = { "battleon", "Enter", "Spawn" };

            public override string ToString() => Display;
        }
    }
}
