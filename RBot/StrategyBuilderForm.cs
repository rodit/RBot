using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using RBot.Quests;
using RBot.Strategy;
using RBot.Utils;

namespace RBot
{
    public partial class StrategyBuilderForm : HideForm
    {
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        private ObtainItemDataHolder _obtain = new ObtainItemDataHolder();
        private StrategyDatabase _db = new StrategyDatabase();
        public StrategyDatabase Database
        {
            get => _db;
            set
            {
                _db = value;
                _obtain = new ObtainItemDataHolder();
            }
        }

        private string _file;

        public StrategyBuilderForm()
        {
            InitializeComponent();

            SendMessage(txtShopMap.Handle, 0x1501, 1, "Map");
            SendMessage(txtDropMap.Handle, 0x1501, 1, "Map name");
            SendMessage(txtDropMonsters.Handle, 0x1501, 1, "Monster names (Monster1|Monster2|...)");
            SendMessage(txtDropName.Handle, 0x1501, 1, "Drop name");

            Bot.Options.SafeTimings = true;
        }

        private void _UpdateStrats(bool reselect = true)
        {
            List<int> selected = lbStrats.SelectedIndices.Cast<int>().ToList();
            lbStrats.Items.Clear();
            lbStrats.Items.AddRange(Database.ItemStrategies.ToArray());
            if (reselect)
                selected.ForEach(i => lbStrats.SetSelected(i, true));
        }

        private async void btnRegisterQuest_Click(object sender, EventArgs e)
        {
            btnRegisterQuest.Enabled = false;
            if (await Task.Run(() => Database.RegisterQuest((int)numQuestID.Value)))
                _UpdateStrats();
            else
                MessageBox.Show("Failed to load quest.");
            btnRegisterQuest.Enabled = true;
        }

        private async void btnRegisterShop_Click(object sender, EventArgs e)
        {
            btnRegisterShop.Enabled = false;
            if (await Task.Run(() => Database.RegisterShop((int)numShopID.Value)))
                _UpdateStrats();
            else
                MessageBox.Show("Failed to load shop.");
            btnRegisterShop.Enabled = true;
        }

        private void btnRegisterDrop_Click(object sender, EventArgs e)
        {
            Database.RegisterDrop(txtDropMap.Text.Trim(), txtDropMonsters.Text.Trim(), txtDropName.Text.Trim(), chkDropTemp.Checked);
            _UpdateStrats();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            List<ItemStrategy> toRemove = lbStrats.SelectedItems.Cast<ItemStrategy>().ToList();
            toRemove.ForEach(x =>
            {
                lbStrats.Items.Remove(x);
                Database.ItemStrategies.Remove(x);
            });
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbStrats.Items.Clear();
            Database.ItemStrategies.Clear();
        }

        private void btnEditDrops_Click(object sender, EventArgs e)
        {
            PropertyService.EditValue(this, Database, "DropAggregate");
        }

        private void lbStrats_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemove.Enabled = lbStrats.SelectedItems.Count > 0;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Database = new StrategyDatabase();
            _UpdateStrats(false);
            _file = null;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Strategy Databases (*.json)|*.json";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Database = JsonConvert.DeserializeObject<StrategyDatabase>(File.ReadAllText(_file = ofd.FileName), new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All });
                    _UpdateStrats(false);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_file == null)
                saveAsToolStripMenuItem.PerformClick();
            else
                _Save(_file);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Strategy Databases (*.json)|*.json";
                if (sfd.ShowDialog() == DialogResult.OK)
                    _Save(_file = sfd.FileName);
            }
        }

        private void _Save(string file)
        {
            File.WriteAllText(file, JsonConvert.SerializeObject(Database, Formatting.Indented, new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All }));
        }

        private void generateScriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PropertyService.EditValue(this, _obtain, "Items");
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "RBot Scripts (*.cs)|*.cs";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sfd.FileName, _GenCode(_obtain.Items));
                }
            }
        }

        private string _GenCode(List<ObtainItemData> obtain)
        {
            CodeStringBuilder sb = new CodeStringBuilder()
                .AppendLine("using System;")
                .AppendLine("using RBot;")
                .AppendLine("using RBot.Strategy;")
                .AppendLine("using Newtonsoft.Json;")
                .AppendLine()
                .AppendLine("public class Script")
                .AppendLine("{")
                .Indent()
                .AppendLine("public void ScriptMain(ScriptInterface bot)")
                .AppendLine("{")
                .Indent()
                .AppendLine("bot.Options.SafeTimings = true;")
                .AppendLine("bot.Options.RestPackets = true;")
                .AppendLine("bot.Options.ExitCombatBeforeQuest = true;")
                .AppendLine()
                .AppendLine("bot.Skills.StartSkills(\"Skills/Generic.xml\");")
                .AppendLine()
                .AppendLine($"bot.Strategy = JsonConvert.DeserializeObject<StrategyDatabase>({JsonConvert.SerializeObject(Database, new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All }).ToLiteral()}, new JsonSerializerSettings() {{ TypeNameHandling = TypeNameHandling.All }});")
                .AppendLine();

            obtain.ForEach(i => sb.AppendLine($"bot.Strategy.AggregateDrops({i.Name.ToLiteral()}, false);"));
            obtain.ForEach(i => sb.AppendLine($"bot.Strategy.Obtain({i.Name.ToLiteral()}, {i.Quantity});"));

            return sb.UnIndent()
                .AppendLine("}")
                .UnIndent()
                .AppendLine("}")
                .ToString();
        }

        public class ObtainItemData
        {
            public string Name { get; set; } = "Item Name";
            public int Quantity { get; set; } = 1;

            public override string ToString()
            {
                return $"{Name} x {Quantity}";
            }
        }

        public class ObtainItemDataHolder
        {
            public List<ObtainItemData> Items { get; set; } = new List<ObtainItemData>();
        }
    }
}
