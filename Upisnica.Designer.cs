namespace eDnevnikproj
{
    partial class Upisnica
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
            this.textBoxupisnica = new System.Windows.Forms.TextBox();
            this.combogodina = new System.Windows.Forms.ComboBox();
            this.comboucenik = new System.Windows.Forms.ComboBox();
            this.comboodeljenje = new System.Windows.Forms.ComboBox();
            this.lblid = new System.Windows.Forms.Label();
            this.lblgodina = new System.Windows.Forms.Label();
            this.lblodeljenje = new System.Windows.Forms.Label();
            this.lblucenik = new System.Windows.Forms.Label();
            this.dataGridupisnica = new System.Windows.Forms.DataGridView();
            this.buttondodaj = new System.Windows.Forms.Button();
            this.buttonizzmeni = new System.Windows.Forms.Button();
            this.buttonobrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridupisnica)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxupisnica
            // 
            this.textBoxupisnica.Location = new System.Drawing.Point(42, 32);
            this.textBoxupisnica.Name = "textBoxupisnica";
            this.textBoxupisnica.Size = new System.Drawing.Size(166, 20);
            this.textBoxupisnica.TabIndex = 0;
            // 
            // combogodina
            // 
            this.combogodina.FormattingEnabled = true;
            this.combogodina.Location = new System.Drawing.Point(214, 32);
            this.combogodina.Name = "combogodina";
            this.combogodina.Size = new System.Drawing.Size(166, 21);
            this.combogodina.TabIndex = 1;
            this.combogodina.SelectedIndexChanged += new System.EventHandler(this.combogodina_SelectedIndexChanged);
            // 
            // comboucenik
            // 
            this.comboucenik.FormattingEnabled = true;
            this.comboucenik.Location = new System.Drawing.Point(558, 31);
            this.comboucenik.Name = "comboucenik";
            this.comboucenik.Size = new System.Drawing.Size(166, 21);
            this.comboucenik.TabIndex = 2;
            // 
            // comboodeljenje
            // 
            this.comboodeljenje.FormattingEnabled = true;
            this.comboodeljenje.Location = new System.Drawing.Point(386, 31);
            this.comboodeljenje.Name = "comboodeljenje";
            this.comboodeljenje.Size = new System.Drawing.Size(166, 21);
            this.comboodeljenje.TabIndex = 3;
            this.comboodeljenje.SelectedIndexChanged += new System.EventHandler(this.comboodeljenje_SelectedIndexChanged);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(114, 9);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(23, 20);
            this.lblid.TabIndex = 4;
            this.lblid.Text = "Id";
            // 
            // lblgodina
            // 
            this.lblgodina.AutoSize = true;
            this.lblgodina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgodina.Location = new System.Drawing.Point(262, 9);
            this.lblgodina.Name = "lblgodina";
            this.lblgodina.Size = new System.Drawing.Size(61, 20);
            this.lblgodina.TabIndex = 5;
            this.lblgodina.Text = "Godina";
            // 
            // lblodeljenje
            // 
            this.lblodeljenje.AutoSize = true;
            this.lblodeljenje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblodeljenje.Location = new System.Drawing.Point(435, 8);
            this.lblodeljenje.Name = "lblodeljenje";
            this.lblodeljenje.Size = new System.Drawing.Size(75, 20);
            this.lblodeljenje.TabIndex = 6;
            this.lblodeljenje.Text = "Odeljenje";
            // 
            // lblucenik
            // 
            this.lblucenik.AutoSize = true;
            this.lblucenik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblucenik.Location = new System.Drawing.Point(617, 8);
            this.lblucenik.Name = "lblucenik";
            this.lblucenik.Size = new System.Drawing.Size(58, 20);
            this.lblucenik.TabIndex = 7;
            this.lblucenik.Text = "Ucenik";
            // 
            // dataGridupisnica
            // 
            this.dataGridupisnica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridupisnica.Location = new System.Drawing.Point(42, 132);
            this.dataGridupisnica.Name = "dataGridupisnica";
            this.dataGridupisnica.Size = new System.Drawing.Size(682, 295);
            this.dataGridupisnica.TabIndex = 8;
            this.dataGridupisnica.CurrentCellChanged += new System.EventHandler(this.dataGridupisnica_CurrentCellChanged);
            // 
            // buttondodaj
            // 
            this.buttondodaj.Location = new System.Drawing.Point(135, 58);
            this.buttondodaj.Name = "buttondodaj";
            this.buttondodaj.Size = new System.Drawing.Size(164, 50);
            this.buttondodaj.TabIndex = 9;
            this.buttondodaj.Text = "Dodaj";
            this.buttondodaj.UseVisualStyleBackColor = true;
            this.buttondodaj.Click += new System.EventHandler(this.buttondodaj_Click);
            // 
            // buttonizzmeni
            // 
            this.buttonizzmeni.Location = new System.Drawing.Point(305, 58);
            this.buttonizzmeni.Name = "buttonizzmeni";
            this.buttonizzmeni.Size = new System.Drawing.Size(164, 50);
            this.buttonizzmeni.TabIndex = 10;
            this.buttonizzmeni.Text = "Izmeni";
            this.buttonizzmeni.UseVisualStyleBackColor = true;
            this.buttonizzmeni.Click += new System.EventHandler(this.buttonizzmeni_Click);
            // 
            // buttonobrisi
            // 
            this.buttonobrisi.Location = new System.Drawing.Point(475, 58);
            this.buttonobrisi.Name = "buttonobrisi";
            this.buttonobrisi.Size = new System.Drawing.Size(164, 50);
            this.buttonobrisi.TabIndex = 11;
            this.buttonobrisi.Text = "Obrisi";
            this.buttonobrisi.UseVisualStyleBackColor = true;
            this.buttonobrisi.Click += new System.EventHandler(this.buttonobrisi_Click);
            // 
            // Upisnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonobrisi);
            this.Controls.Add(this.buttonizzmeni);
            this.Controls.Add(this.buttondodaj);
            this.Controls.Add(this.dataGridupisnica);
            this.Controls.Add(this.lblucenik);
            this.Controls.Add(this.lblodeljenje);
            this.Controls.Add(this.lblgodina);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.comboodeljenje);
            this.Controls.Add(this.comboucenik);
            this.Controls.Add(this.combogodina);
            this.Controls.Add(this.textBoxupisnica);
            this.Name = "Upisnica";
            this.Text = "Upisnica";
            this.Load += new System.EventHandler(this.Upisnica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridupisnica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxupisnica;
        private System.Windows.Forms.ComboBox combogodina;
        private System.Windows.Forms.ComboBox comboucenik;
        private System.Windows.Forms.ComboBox comboodeljenje;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblgodina;
        private System.Windows.Forms.Label lblodeljenje;
        private System.Windows.Forms.Label lblucenik;
        private System.Windows.Forms.DataGridView dataGridupisnica;
        private System.Windows.Forms.Button buttondodaj;
        private System.Windows.Forms.Button buttonizzmeni;
        private System.Windows.Forms.Button buttonobrisi;
    }
}