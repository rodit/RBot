namespace RBot
{
    partial class FastTravelUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FastTravelUserControl));
            this.grpFastTravel = new System.Windows.Forms.GroupBox();
            this.txtAddTravel = new System.Windows.Forms.TextBox();
            this.btnAddTravel = new System.Windows.Forms.Button();
            this.btnTravelCustom = new System.Windows.Forms.Button();
            this.cbCustomTravels = new System.Windows.Forms.ComboBox();
            this.btnTravelBinky = new System.Windows.Forms.Button();
            this.btnTravelMuseum = new System.Windows.Forms.Button();
            this.btnTravelCarnage = new System.Windows.Forms.Button();
            this.btnTravelLae = new System.Windows.Forms.Button();
            this.btnTravelPolish = new System.Windows.Forms.Button();
            this.btnTravelYinYang = new System.Windows.Forms.Button();
            this.btnTravelTaro = new System.Windows.Forms.Button();
            this.btnTravelSwindle = new System.Windows.Forms.Button();
            this.btnTravelTercess = new System.Windows.Forms.Button();
            this.btnTravelNulgath = new System.Windows.Forms.Button();
            this.FastTravelTT = new System.Windows.Forms.ToolTip(this.components);
            this.grpFastTravel.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpFastTravel
            // 
            this.grpFastTravel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFastTravel.Controls.Add(this.txtAddTravel);
            this.grpFastTravel.Controls.Add(this.btnAddTravel);
            this.grpFastTravel.Controls.Add(this.btnTravelCustom);
            this.grpFastTravel.Controls.Add(this.cbCustomTravels);
            this.grpFastTravel.Controls.Add(this.btnTravelBinky);
            this.grpFastTravel.Controls.Add(this.btnTravelMuseum);
            this.grpFastTravel.Controls.Add(this.btnTravelCarnage);
            this.grpFastTravel.Controls.Add(this.btnTravelLae);
            this.grpFastTravel.Controls.Add(this.btnTravelPolish);
            this.grpFastTravel.Controls.Add(this.btnTravelYinYang);
            this.grpFastTravel.Controls.Add(this.btnTravelTaro);
            this.grpFastTravel.Controls.Add(this.btnTravelSwindle);
            this.grpFastTravel.Controls.Add(this.btnTravelTercess);
            this.grpFastTravel.Controls.Add(this.btnTravelNulgath);
            this.grpFastTravel.Location = new System.Drawing.Point(0, 5);
            this.grpFastTravel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpFastTravel.Name = "grpFastTravel";
            this.grpFastTravel.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpFastTravel.Size = new System.Drawing.Size(245, 210);
            this.grpFastTravel.TabIndex = 5;
            this.grpFastTravel.TabStop = false;
            this.grpFastTravel.Text = "Fast Travel";
            this.FastTravelTT.SetToolTip(this.grpFastTravel, "Click: travel to a public room;\r\nCtrl + click: travel to random private room.");
            // 
            // txtAddTravel
            // 
            this.txtAddTravel.Location = new System.Drawing.Point(5, 187);
            this.txtAddTravel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAddTravel.Name = "txtAddTravel";
            this.txtAddTravel.PlaceholderText = "Name, Map, Cell, Pad";
            this.txtAddTravel.Size = new System.Drawing.Size(167, 23);
            this.txtAddTravel.TabIndex = 17;
            // 
            // btnAddTravel
            // 
            this.btnAddTravel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddTravel.Location = new System.Drawing.Point(175, 187);
            this.btnAddTravel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddTravel.Name = "btnAddTravel";
            this.btnAddTravel.Size = new System.Drawing.Size(64, 23);
            this.btnAddTravel.TabIndex = 16;
            this.btnAddTravel.Tag = "";
            this.btnAddTravel.Text = "Add";
            this.FastTravelTT.SetToolTip(this.btnAddTravel, resources.GetString("btnAddTravel.ToolTip"));
            this.btnAddTravel.UseVisualStyleBackColor = true;
            this.btnAddTravel.Click += new System.EventHandler(this.btnAddTravel_Click);
            // 
            // btnTravelCustom
            // 
            this.btnTravelCustom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTravelCustom.Location = new System.Drawing.Point(175, 155);
            this.btnTravelCustom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTravelCustom.Name = "btnTravelCustom";
            this.btnTravelCustom.Size = new System.Drawing.Size(64, 23);
            this.btnTravelCustom.TabIndex = 15;
            this.btnTravelCustom.Tag = "";
            this.btnTravelCustom.Text = "Go";
            this.FastTravelTT.SetToolTip(this.btnTravelCustom, "Alt + click: remove the selected item.");
            this.btnTravelCustom.UseVisualStyleBackColor = true;
            this.btnTravelCustom.Click += new System.EventHandler(this.btnTravelCustom_Click);
            // 
            // cbCustomTravels
            // 
            this.cbCustomTravels.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCustomTravels.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCustomTravels.FormattingEnabled = true;
            this.cbCustomTravels.Location = new System.Drawing.Point(5, 155);
            this.cbCustomTravels.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbCustomTravels.Name = "cbCustomTravels";
            this.cbCustomTravels.Size = new System.Drawing.Size(167, 23);
            this.cbCustomTravels.TabIndex = 5;
            // 
            // btnTravelBinky
            // 
            this.btnTravelBinky.Location = new System.Drawing.Point(5, 127);
            this.btnTravelBinky.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTravelBinky.Name = "btnTravelBinky";
            this.btnTravelBinky.Size = new System.Drawing.Size(115, 23);
            this.btnTravelBinky.TabIndex = 14;
            this.btnTravelBinky.Tag = "doomvault,r5,Left";
            this.btnTravelBinky.Text = "Binky";
            this.btnTravelBinky.UseVisualStyleBackColor = true;
            // 
            // btnTravelMuseum
            // 
            this.btnTravelMuseum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTravelMuseum.Location = new System.Drawing.Point(125, 127);
            this.btnTravelMuseum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTravelMuseum.Name = "btnTravelMuseum";
            this.btnTravelMuseum.Size = new System.Drawing.Size(115, 23);
            this.btnTravelMuseum.TabIndex = 13;
            this.btnTravelMuseum.Tag = "museum,Crossroad,Left";
            this.btnTravelMuseum.Text = "Museum";
            this.btnTravelMuseum.UseVisualStyleBackColor = true;
            // 
            // btnTravelCarnage
            // 
            this.btnTravelCarnage.Location = new System.Drawing.Point(5, 99);
            this.btnTravelCarnage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTravelCarnage.Name = "btnTravelCarnage";
            this.btnTravelCarnage.Size = new System.Drawing.Size(115, 23);
            this.btnTravelCarnage.TabIndex = 12;
            this.btnTravelCarnage.Tag = "tercessuinotlim,m4,Right";
            this.btnTravelCarnage.Text = "Carnage";
            this.btnTravelCarnage.UseVisualStyleBackColor = true;
            // 
            // btnTravelLae
            // 
            this.btnTravelLae.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTravelLae.Location = new System.Drawing.Point(125, 99);
            this.btnTravelLae.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTravelLae.Name = "btnTravelLae";
            this.btnTravelLae.Size = new System.Drawing.Size(115, 23);
            this.btnTravelLae.TabIndex = 11;
            this.btnTravelLae.Tag = "tercessuinotlim,m5,Top";
            this.btnTravelLae.Text = "Lae";
            this.btnTravelLae.UseVisualStyleBackColor = true;
            // 
            // btnTravelPolish
            // 
            this.btnTravelPolish.Location = new System.Drawing.Point(5, 72);
            this.btnTravelPolish.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTravelPolish.Name = "btnTravelPolish";
            this.btnTravelPolish.Size = new System.Drawing.Size(115, 23);
            this.btnTravelPolish.TabIndex = 10;
            this.btnTravelPolish.Tag = "tercessuinotlim,m12,Right";
            this.btnTravelPolish.Text = "Polish";
            this.btnTravelPolish.UseVisualStyleBackColor = true;
            // 
            // btnTravelYinYang
            // 
            this.btnTravelYinYang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTravelYinYang.Location = new System.Drawing.Point(125, 72);
            this.btnTravelYinYang.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTravelYinYang.Name = "btnTravelYinYang";
            this.btnTravelYinYang.Size = new System.Drawing.Size(115, 23);
            this.btnTravelYinYang.TabIndex = 9;
            this.btnTravelYinYang.Tag = "tercessuinotlim,Twins,Left";
            this.btnTravelYinYang.Text = "Yin Yang";
            this.btnTravelYinYang.UseVisualStyleBackColor = true;
            // 
            // btnTravelTaro
            // 
            this.btnTravelTaro.Location = new System.Drawing.Point(5, 45);
            this.btnTravelTaro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTravelTaro.Name = "btnTravelTaro";
            this.btnTravelTaro.Size = new System.Drawing.Size(115, 23);
            this.btnTravelTaro.TabIndex = 8;
            this.btnTravelTaro.Tag = "tercessuinotlim,Taro,Left";
            this.btnTravelTaro.Text = "VHL/Taro";
            this.btnTravelTaro.UseVisualStyleBackColor = true;
            // 
            // btnTravelSwindle
            // 
            this.btnTravelSwindle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTravelSwindle.Location = new System.Drawing.Point(125, 45);
            this.btnTravelSwindle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTravelSwindle.Name = "btnTravelSwindle";
            this.btnTravelSwindle.Size = new System.Drawing.Size(115, 23);
            this.btnTravelSwindle.TabIndex = 7;
            this.btnTravelSwindle.Tag = "tercessuinotlim,Swindle,Left";
            this.btnTravelSwindle.Text = "Swindle";
            this.btnTravelSwindle.UseVisualStyleBackColor = true;
            // 
            // btnTravelTercess
            // 
            this.btnTravelTercess.Location = new System.Drawing.Point(5, 17);
            this.btnTravelTercess.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTravelTercess.Name = "btnTravelTercess";
            this.btnTravelTercess.Size = new System.Drawing.Size(115, 23);
            this.btnTravelTercess.TabIndex = 6;
            this.btnTravelTercess.Tag = "tercessuinotlim,Enter,Spawn";
            this.btnTravelTercess.Text = "Tercessuinotlim";
            this.btnTravelTercess.UseVisualStyleBackColor = true;
            // 
            // btnTravelNulgath
            // 
            this.btnTravelNulgath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTravelNulgath.Location = new System.Drawing.Point(125, 17);
            this.btnTravelNulgath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTravelNulgath.Name = "btnTravelNulgath";
            this.btnTravelNulgath.Size = new System.Drawing.Size(115, 23);
            this.btnTravelNulgath.TabIndex = 5;
            this.btnTravelNulgath.Tag = "tercessuinotlim,Boss2,Right";
            this.btnTravelNulgath.Text = "Nulgath";
            this.btnTravelNulgath.UseVisualStyleBackColor = true;
            // 
            // FastTravelUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpFastTravel);
            this.Name = "FastTravelUserControl";
            this.Size = new System.Drawing.Size(245, 220);
            this.grpFastTravel.ResumeLayout(false);
            this.grpFastTravel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFastTravel;
        private System.Windows.Forms.TextBox txtAddTravel;
        private System.Windows.Forms.Button btnAddTravel;
        private System.Windows.Forms.ToolTip FastTravelTT;
        private System.Windows.Forms.Button btnTravelCustom;
        private System.Windows.Forms.ComboBox cbCustomTravels;
        private System.Windows.Forms.Button btnTravelBinky;
        private System.Windows.Forms.Button btnTravelMuseum;
        private System.Windows.Forms.Button btnTravelCarnage;
        private System.Windows.Forms.Button btnTravelLae;
        private System.Windows.Forms.Button btnTravelPolish;
        private System.Windows.Forms.Button btnTravelYinYang;
        private System.Windows.Forms.Button btnTravelTaro;
        private System.Windows.Forms.Button btnTravelSwindle;
        private System.Windows.Forms.Button btnTravelTercess;
        private System.Windows.Forms.Button btnTravelNulgath;
    }
}
