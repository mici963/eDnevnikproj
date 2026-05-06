namespace eDnevnikproj
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            this.textname = new System.Windows.Forms.TextBox();
            this.textpass = new System.Windows.Forms.TextBox();
            this.labzdravo = new System.Windows.Forms.Label();
            this.labemail = new System.Windows.Forms.Label();
            this.lablozinka = new System.Windows.Forms.Label();
            this.butlogin = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // textname
            // 
            this.textname.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textname.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textname.Location = new System.Drawing.Point(308, 112);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(200, 24);
            this.textname.TabIndex = 0;
            // 
            // textpass
            // 
            this.textpass.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textpass.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textpass.Location = new System.Drawing.Point(308, 179);
            this.textpass.Name = "textpass";
            this.textpass.Size = new System.Drawing.Size(200, 24);
            this.textpass.TabIndex = 1;
            // 
            // labzdravo
            // 
            this.labzdravo.AutoSize = true;
            this.labzdravo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labzdravo.Location = new System.Drawing.Point(256, 36);
            this.labzdravo.Name = "labzdravo";
            this.labzdravo.Size = new System.Drawing.Size(289, 22);
            this.labzdravo.TabIndex = 2;
            this.labzdravo.Text = "Zdravo. Da bi ste nastavili unesite:";
            // 
            // labemail
            // 
            this.labemail.AutoSize = true;
            this.labemail.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labemail.Location = new System.Drawing.Point(228, 111);
            this.labemail.Name = "labemail";
            this.labemail.Size = new System.Drawing.Size(54, 21);
            this.labemail.TabIndex = 3;
            this.labemail.Text = "Email:";
            // 
            // lablozinka
            // 
            this.lablozinka.AutoSize = true;
            this.lablozinka.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablozinka.Location = new System.Drawing.Point(228, 176);
            this.lablozinka.Name = "lablozinka";
            this.lablozinka.Size = new System.Drawing.Size(70, 21);
            this.lablozinka.TabIndex = 4;
            this.lablozinka.Text = "Lozinka:";
            // 
            // butlogin
            // 
            this.butlogin.BackColor = System.Drawing.Color.IndianRed;
            this.butlogin.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butlogin.Location = new System.Drawing.Point(325, 245);
            this.butlogin.Name = "butlogin";
            this.butlogin.Size = new System.Drawing.Size(141, 53);
            this.butlogin.TabIndex = 5;
            this.butlogin.Text = "Login";
            this.butlogin.UseVisualStyleBackColor = false;
            this.butlogin.Click += new System.EventHandler(this.butlogin_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butlogin);
            this.Controls.Add(this.lablozinka);
            this.Controls.Add(this.labemail);
            this.Controls.Add(this.labzdravo);
            this.Controls.Add(this.textpass);
            this.Controls.Add(this.textname);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.TextBox textpass;
        private System.Windows.Forms.Label labzdravo;
        private System.Windows.Forms.Label labemail;
        private System.Windows.Forms.Label lablozinka;
        private System.Windows.Forms.Button butlogin;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}