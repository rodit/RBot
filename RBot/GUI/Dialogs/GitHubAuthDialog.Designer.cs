namespace RBot;

partial class GitHubAuthDialog
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
            this.btnDeviceCode = new System.Windows.Forms.Button();
            this.lblGHAuth = new System.Windows.Forms.Label();
            this.btnAuth = new System.Windows.Forms.Button();
            this.txtUserCode = new System.Windows.Forms.TextBox();
            this.btnOpenBrowser = new System.Windows.Forms.Button();
            this.lblcopy = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDeviceCode
            // 
            this.btnDeviceCode.Location = new System.Drawing.Point(12, 112);
            this.btnDeviceCode.Name = "btnDeviceCode";
            this.btnDeviceCode.Size = new System.Drawing.Size(164, 23);
            this.btnDeviceCode.TabIndex = 0;
            this.btnDeviceCode.Text = "Get User Code";
            this.btnDeviceCode.UseVisualStyleBackColor = true;
            this.btnDeviceCode.Click += new System.EventHandler(this.btnDeviceCode_Click);
            // 
            // lblGHAuth
            // 
            this.lblGHAuth.AutoSize = true;
            this.lblGHAuth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGHAuth.Location = new System.Drawing.Point(12, 9);
            this.lblGHAuth.Name = "lblGHAuth";
            this.lblGHAuth.Size = new System.Drawing.Size(164, 21);
            this.lblGHAuth.TabIndex = 1;
            this.lblGHAuth.Text = "GitHub Authentication";
            // 
            // btnAuth
            // 
            this.btnAuth.Location = new System.Drawing.Point(12, 170);
            this.btnAuth.Name = "btnAuth";
            this.btnAuth.Size = new System.Drawing.Size(164, 23);
            this.btnAuth.TabIndex = 2;
            this.btnAuth.Text = "Authorize";
            this.btnAuth.UseVisualStyleBackColor = true;
            this.btnAuth.Click += new System.EventHandler(this.btnAuth_Click);
            // 
            // txtUserCode
            // 
            this.txtUserCode.Location = new System.Drawing.Point(12, 33);
            this.txtUserCode.Name = "txtUserCode";
            this.txtUserCode.Size = new System.Drawing.Size(164, 23);
            this.txtUserCode.TabIndex = 3;
            // 
            // btnOpenBrowser
            // 
            this.btnOpenBrowser.Location = new System.Drawing.Point(12, 141);
            this.btnOpenBrowser.Name = "btnOpenBrowser";
            this.btnOpenBrowser.Size = new System.Drawing.Size(164, 23);
            this.btnOpenBrowser.TabIndex = 4;
            this.btnOpenBrowser.Text = "Open Browser";
            this.btnOpenBrowser.UseVisualStyleBackColor = true;
            this.btnOpenBrowser.Click += new System.EventHandler(this.btnOpenBrowser_Click);
            // 
            // lblcopy
            // 
            this.lblcopy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblcopy.Location = new System.Drawing.Point(12, 60);
            this.lblcopy.Name = "lblcopy";
            this.lblcopy.Size = new System.Drawing.Size(164, 49);
            this.lblcopy.TabIndex = 5;
            this.lblcopy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 199);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(164, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // GitHubAuthDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 229);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblcopy);
            this.Controls.Add(this.btnOpenBrowser);
            this.Controls.Add(this.txtUserCode);
            this.Controls.Add(this.btnAuth);
            this.Controls.Add(this.lblGHAuth);
            this.Controls.Add(this.btnDeviceCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GitHubAuthDialog";
            this.Text = "GitHubAuthDialog";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GitHubAuthDialog_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnDeviceCode;
    private System.Windows.Forms.Label lblGHAuth;
    private System.Windows.Forms.Button btnAuth;
    private System.Windows.Forms.TextBox txtUserCode;
    private System.Windows.Forms.Button btnOpenBrowser;
    private System.Windows.Forms.Label lblcopy;
    private System.Windows.Forms.Button btnClose;
}
