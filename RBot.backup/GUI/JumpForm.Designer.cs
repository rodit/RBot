namespace RBot
{
    partial class JumpForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbCell = new System.Windows.Forms.ComboBox();
            this.cbPads = new System.Windows.Forms.ComboBox();
            this.btnJump = new System.Windows.Forms.Button();
            this.btnGetCurrent = new System.Windows.Forms.Button();
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
            this.grpFastTravel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbCell
            // 
            this.cbCell.FormattingEnabled = true;
            this.cbCell.Location = new System.Drawing.Point(5, 10);
            this.cbCell.Name = "cbCell";
            this.cbCell.Size = new System.Drawing.Size(100, 21);
            this.cbCell.TabIndex = 0;
            // 
            // cbPads
            // 
            this.cbPads.FormattingEnabled = true;
            this.cbPads.Items.AddRange(new object[] {
            "Spawn",
            "Center",
            "Left",
            "Right",
            "Up",
            "Down",
            "Top",
            "Bottom"});
            this.cbPads.Location = new System.Drawing.Point(110, 10);
            this.cbPads.Name = "cbPads";
            this.cbPads.Size = new System.Drawing.Size(100, 21);
            this.cbPads.TabIndex = 1;
            // 
            // btnJump
            // 
            this.btnJump.Location = new System.Drawing.Point(110, 36);
            this.btnJump.Name = "btnJump";
            this.btnJump.Size = new System.Drawing.Size(100, 23);
            this.btnJump.TabIndex = 2;
            this.btnJump.Text = "Jump";
            this.btnJump.UseVisualStyleBackColor = true;
            this.btnJump.Click += new System.EventHandler(this.btnJump_Click);
            // 
            // btnGetCurrent
            // 
            this.btnGetCurrent.Location = new System.Drawing.Point(5, 36);
            this.btnGetCurrent.Name = "btnGetCurrent";
            this.btnGetCurrent.Size = new System.Drawing.Size(100, 23);
            this.btnGetCurrent.TabIndex = 3;
            this.btnGetCurrent.Text = "Get Current";
            this.btnGetCurrent.UseVisualStyleBackColor = true;
            this.btnGetCurrent.Click += new System.EventHandler(this.btnGetCurrent_Click);
            // 
            // grpFastTravel
            // 
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
            this.grpFastTravel.Location = new System.Drawing.Point(5, 65);
            this.grpFastTravel.Name = "grpFastTravel";
            this.grpFastTravel.Size = new System.Drawing.Size(205, 210);
            this.grpFastTravel.TabIndex = 4;
            this.grpFastTravel.TabStop = false;
            this.grpFastTravel.Text = "Fast Travel";
            // 
            // txtAddTravel
            // 
            this.txtAddTravel.Location = new System.Drawing.Point(0, 184);
            this.txtAddTravel.Name = "txtAddTravel";
            this.txtAddTravel.Size = new System.Drawing.Size(144, 20);
            this.txtAddTravel.TabIndex = 17;
            // 
            // btnAddTravel
            // 
            this.btnAddTravel.Location = new System.Drawing.Point(150, 183);
            this.btnAddTravel.Name = "btnAddTravel";
            this.btnAddTravel.Size = new System.Drawing.Size(55, 23);
            this.btnAddTravel.TabIndex = 16;
            this.btnAddTravel.Tag = "";
            this.btnAddTravel.Text = "Add";
            this.btnAddTravel.UseVisualStyleBackColor = true;
            this.btnAddTravel.Click += new System.EventHandler(this.btnAddTravel_Click);
            // 
            // btnTravelCustom
            // 
            this.btnTravelCustom.Location = new System.Drawing.Point(150, 155);
            this.btnTravelCustom.Name = "btnTravelCustom";
            this.btnTravelCustom.Size = new System.Drawing.Size(55, 23);
            this.btnTravelCustom.TabIndex = 15;
            this.btnTravelCustom.Tag = "";
            this.btnTravelCustom.Text = "Go";
            this.btnTravelCustom.UseVisualStyleBackColor = true;
            this.btnTravelCustom.Click += new System.EventHandler(this.btnTravelCustom_Click);
            // 
            // cbCustomTravels
            // 
            this.cbCustomTravels.FormattingEnabled = true;
            this.cbCustomTravels.Location = new System.Drawing.Point(0, 156);
            this.cbCustomTravels.Name = "cbCustomTravels";
            this.cbCustomTravels.Size = new System.Drawing.Size(144, 21);
            this.cbCustomTravels.TabIndex = 5;
            // 
            // btnTravelBinky
            // 
            this.btnTravelBinky.Location = new System.Drawing.Point(0, 127);
            this.btnTravelBinky.Name = "btnTravelBinky";
            this.btnTravelBinky.Size = new System.Drawing.Size(100, 23);
            this.btnTravelBinky.TabIndex = 14;
            this.btnTravelBinky.Tag = "doomvault,r5,Left";
            this.btnTravelBinky.Text = "Binky";
            this.btnTravelBinky.UseVisualStyleBackColor = true;
            // 
            // btnTravelMuseum
            // 
            this.btnTravelMuseum.Location = new System.Drawing.Point(105, 127);
            this.btnTravelMuseum.Name = "btnTravelMuseum";
            this.btnTravelMuseum.Size = new System.Drawing.Size(100, 23);
            this.btnTravelMuseum.TabIndex = 13;
            this.btnTravelMuseum.Tag = "museum,Crossroad,Spawn";
            this.btnTravelMuseum.Text = "Museum";
            this.btnTravelMuseum.UseVisualStyleBackColor = true;
            // 
            // btnTravelCarnage
            // 
            this.btnTravelCarnage.Location = new System.Drawing.Point(0, 99);
            this.btnTravelCarnage.Name = "btnTravelCarnage";
            this.btnTravelCarnage.Size = new System.Drawing.Size(100, 23);
            this.btnTravelCarnage.TabIndex = 12;
            this.btnTravelCarnage.Tag = "tercessuinotlim,m4,Right";
            this.btnTravelCarnage.Text = "Carnage";
            this.btnTravelCarnage.UseVisualStyleBackColor = true;
            // 
            // btnTravelLae
            // 
            this.btnTravelLae.Location = new System.Drawing.Point(105, 99);
            this.btnTravelLae.Name = "btnTravelLae";
            this.btnTravelLae.Size = new System.Drawing.Size(100, 23);
            this.btnTravelLae.TabIndex = 11;
            this.btnTravelLae.Tag = "tercessuinotlim,m5,Top";
            this.btnTravelLae.Text = "Lae";
            this.btnTravelLae.UseVisualStyleBackColor = true;
            // 
            // btnTravelPolish
            // 
            this.btnTravelPolish.Location = new System.Drawing.Point(0, 71);
            this.btnTravelPolish.Name = "btnTravelPolish";
            this.btnTravelPolish.Size = new System.Drawing.Size(100, 23);
            this.btnTravelPolish.TabIndex = 10;
            this.btnTravelPolish.Tag = "tercessuinotlim,m12,Right";
            this.btnTravelPolish.Text = "Polish";
            this.btnTravelPolish.UseVisualStyleBackColor = true;
            // 
            // btnTravelYinYang
            // 
            this.btnTravelYinYang.Location = new System.Drawing.Point(105, 71);
            this.btnTravelYinYang.Name = "btnTravelYinYang";
            this.btnTravelYinYang.Size = new System.Drawing.Size(100, 23);
            this.btnTravelYinYang.TabIndex = 9;
            this.btnTravelYinYang.Tag = "tercessuinotlim,Twins,Left";
            this.btnTravelYinYang.Text = "Yin Yang";
            this.btnTravelYinYang.UseVisualStyleBackColor = true;
            // 
            // btnTravelTaro
            // 
            this.btnTravelTaro.Location = new System.Drawing.Point(0, 43);
            this.btnTravelTaro.Name = "btnTravelTaro";
            this.btnTravelTaro.Size = new System.Drawing.Size(100, 23);
            this.btnTravelTaro.TabIndex = 8;
            this.btnTravelTaro.Tag = "tercessuinotlim,Taro,Left";
            this.btnTravelTaro.Text = "VHL/Taro";
            this.btnTravelTaro.UseVisualStyleBackColor = true;
            // 
            // btnTravelSwindle
            // 
            this.btnTravelSwindle.Location = new System.Drawing.Point(105, 43);
            this.btnTravelSwindle.Name = "btnTravelSwindle";
            this.btnTravelSwindle.Size = new System.Drawing.Size(100, 23);
            this.btnTravelSwindle.TabIndex = 7;
            this.btnTravelSwindle.Tag = "tercessuinotlim,Swindle,Left";
            this.btnTravelSwindle.Text = "Swindle";
            this.btnTravelSwindle.UseVisualStyleBackColor = true;
            // 
            // btnTravelTercess
            // 
            this.btnTravelTercess.Location = new System.Drawing.Point(0, 15);
            this.btnTravelTercess.Name = "btnTravelTercess";
            this.btnTravelTercess.Size = new System.Drawing.Size(100, 23);
            this.btnTravelTercess.TabIndex = 6;
            this.btnTravelTercess.Tag = "tercessuinotlim,Enter,Spawn";
            this.btnTravelTercess.Text = "Tercessuinotlim";
            this.btnTravelTercess.UseVisualStyleBackColor = true;
            // 
            // btnTravelNulgath
            // 
            this.btnTravelNulgath.Location = new System.Drawing.Point(105, 15);
            this.btnTravelNulgath.Name = "btnTravelNulgath";
            this.btnTravelNulgath.Size = new System.Drawing.Size(100, 23);
            this.btnTravelNulgath.TabIndex = 5;
            this.btnTravelNulgath.Tag = "tercessuinotlim,Boss2,Right";
            this.btnTravelNulgath.Text = "Nulgath";
            this.btnTravelNulgath.UseVisualStyleBackColor = true;
            // 
            // JumpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 276);
            this.Controls.Add(this.grpFastTravel);
            this.Controls.Add(this.btnGetCurrent);
            this.Controls.Add(this.btnJump);
            this.Controls.Add(this.cbPads);
            this.Controls.Add(this.cbCell);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "JumpForm";
            this.Text = "Jump";
            this.grpFastTravel.ResumeLayout(false);
            this.grpFastTravel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCell;
        private System.Windows.Forms.ComboBox cbPads;
        private System.Windows.Forms.Button btnJump;
        private System.Windows.Forms.Button btnGetCurrent;
        private System.Windows.Forms.GroupBox grpFastTravel;
        private System.Windows.Forms.TextBox txtAddTravel;
        private System.Windows.Forms.Button btnAddTravel;
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