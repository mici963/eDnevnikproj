namespace eDnevnikproj
{
    partial class Ocena
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
            this.comboBoxprofesor = new System.Windows.Forms.ComboBox();
            this.comboBoxucenik = new System.Windows.Forms.ComboBox();
            this.comboBoxocena = new System.Windows.Forms.ComboBox();
            this.comboBoxpredmet = new System.Windows.Forms.ComboBox();
            this.comboBoxodeljenje = new System.Windows.Forms.ComboBox();
            this.comboBoxgodina = new System.Windows.Forms.ComboBox();
            this.datum = new System.Windows.Forms.DateTimePicker();
            this.textBoxid = new System.Windows.Forms.TextBox();
            this.buttondodaj = new System.Windows.Forms.Button();
            this.buttonizmeni = new System.Windows.Forms.Button();
            this.buttonobrisi = new System.Windows.Forms.Button();
            this.gridocena = new System.Windows.Forms.DataGridView();
            this.labelgodina = new System.Windows.Forms.Label();
            this.labelprofesor = new System.Windows.Forms.Label();
            this.labelpredmet = new System.Windows.Forms.Label();
            this.labelodeljenje = new System.Windows.Forms.Label();
            this.labelucenik = new System.Windows.Forms.Label();
            this.labelocena = new System.Windows.Forms.Label();
            this.labelid = new System.Windows.Forms.Label();
            this.labeldatum = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridocena)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxprofesor
            // 
            this.comboBoxprofesor.FormattingEnabled = true;
            this.comboBoxprofesor.Location = new System.Drawing.Point(241, 40);
            this.comboBoxprofesor.Name = "comboBoxprofesor";
            this.comboBoxprofesor.Size = new System.Drawing.Size(129, 21);
            this.comboBoxprofesor.TabIndex = 0;
            this.comboBoxprofesor.SelectedIndexChanged += new System.EventHandler(this.comboBoxprofesor_SelectedIndexChanged);
            // 
            // comboBoxucenik
            // 
            this.comboBoxucenik.FormattingEnabled = true;
            this.comboBoxucenik.Location = new System.Drawing.Point(112, 94);
            this.comboBoxucenik.Name = "comboBoxucenik";
            this.comboBoxucenik.Size = new System.Drawing.Size(129, 21);
            this.comboBoxucenik.TabIndex = 1;
            // 
            // comboBoxocena
            // 
            this.comboBoxocena.FormattingEnabled = true;
            this.comboBoxocena.Location = new System.Drawing.Point(241, 94);
            this.comboBoxocena.Name = "comboBoxocena";
            this.comboBoxocena.Size = new System.Drawing.Size(129, 21);
            this.comboBoxocena.TabIndex = 2;
            // 
            // comboBoxpredmet
            // 
            this.comboBoxpredmet.FormattingEnabled = true;
            this.comboBoxpredmet.Location = new System.Drawing.Point(371, 40);
            this.comboBoxpredmet.Name = "comboBoxpredmet";
            this.comboBoxpredmet.Size = new System.Drawing.Size(129, 21);
            this.comboBoxpredmet.TabIndex = 3;
            this.comboBoxpredmet.SelectedValueChanged += new System.EventHandler(this.comboBoxpredmet_SelectedValueChanged);
            // 
            // comboBoxodeljenje
            // 
            this.comboBoxodeljenje.FormattingEnabled = true;
            this.comboBoxodeljenje.Location = new System.Drawing.Point(511, 40);
            this.comboBoxodeljenje.Name = "comboBoxodeljenje";
            this.comboBoxodeljenje.Size = new System.Drawing.Size(129, 21);
            this.comboBoxodeljenje.TabIndex = 4;
            this.comboBoxodeljenje.SelectedValueChanged += new System.EventHandler(this.comboBoxodeljenje_SelectedValueChanged);
            // 
            // comboBoxgodina
            // 
            this.comboBoxgodina.FormattingEnabled = true;
            this.comboBoxgodina.Location = new System.Drawing.Point(112, 40);
            this.comboBoxgodina.Name = "comboBoxgodina";
            this.comboBoxgodina.Size = new System.Drawing.Size(129, 21);
            this.comboBoxgodina.TabIndex = 5;
            this.comboBoxgodina.SelectedValueChanged += new System.EventHandler(this.comboBoxgodina_SelectedValueChanged);
            // 
            // datum
            // 
            this.datum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datum.Location = new System.Drawing.Point(514, 94);
            this.datum.Name = "datum";
            this.datum.Size = new System.Drawing.Size(122, 20);
            this.datum.TabIndex = 6;
            // 
            // textBoxid
            // 
            this.textBoxid.Enabled = false;
            this.textBoxid.Location = new System.Drawing.Point(371, 94);
            this.textBoxid.Name = "textBoxid";
            this.textBoxid.Size = new System.Drawing.Size(129, 20);
            this.textBoxid.TabIndex = 7;
            // 
            // buttondodaj
            // 
            this.buttondodaj.Location = new System.Drawing.Point(654, 12);
            this.buttondodaj.Name = "buttondodaj";
            this.buttondodaj.Size = new System.Drawing.Size(99, 34);
            this.buttondodaj.TabIndex = 8;
            this.buttondodaj.Text = "Dodaj:";
            this.buttondodaj.UseVisualStyleBackColor = true;
            this.buttondodaj.Click += new System.EventHandler(this.buttondodaj_Click);
            // 
            // buttonizmeni
            // 
            this.buttonizmeni.Location = new System.Drawing.Point(654, 52);
            this.buttonizmeni.Name = "buttonizmeni";
            this.buttonizmeni.Size = new System.Drawing.Size(99, 32);
            this.buttonizmeni.TabIndex = 9;
            this.buttonizmeni.Text = "Izmeni:";
            this.buttonizmeni.UseVisualStyleBackColor = true;
            this.buttonizmeni.Click += new System.EventHandler(this.buttonizmeni_Click);
            // 
            // buttonobrisi
            // 
            this.buttonobrisi.Location = new System.Drawing.Point(654, 87);
            this.buttonobrisi.Name = "buttonobrisi";
            this.buttonobrisi.Size = new System.Drawing.Size(99, 32);
            this.buttonobrisi.TabIndex = 10;
            this.buttonobrisi.Text = "Obrisi:";
            this.buttonobrisi.UseVisualStyleBackColor = true;
            this.buttonobrisi.Click += new System.EventHandler(this.buttonobrisi_Click);
            // 
            // gridocena
            // 
            this.gridocena.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridocena.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridocena.Location = new System.Drawing.Point(26, 190);
            this.gridocena.Name = "gridocena";
            this.gridocena.Size = new System.Drawing.Size(727, 217);
            this.gridocena.TabIndex = 11;
            this.gridocena.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridocena_CellClick);
            // 
            // labelgodina
            // 
            this.labelgodina.AutoSize = true;
            this.labelgodina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelgodina.Location = new System.Drawing.Point(144, 9);
            this.labelgodina.Name = "labelgodina";
            this.labelgodina.Size = new System.Drawing.Size(65, 20);
            this.labelgodina.TabIndex = 12;
            this.labelgodina.Text = "Godina:";
            // 
            // labelprofesor
            // 
            this.labelprofesor.AutoSize = true;
            this.labelprofesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelprofesor.Location = new System.Drawing.Point(269, 9);
            this.labelprofesor.Name = "labelprofesor";
            this.labelprofesor.Size = new System.Drawing.Size(73, 20);
            this.labelprofesor.TabIndex = 13;
            this.labelprofesor.Text = "Profesor:";
            // 
            // labelpredmet
            // 
            this.labelpredmet.AutoSize = true;
            this.labelpredmet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpredmet.Location = new System.Drawing.Point(399, 9);
            this.labelpredmet.Name = "labelpredmet";
            this.labelpredmet.Size = new System.Drawing.Size(73, 20);
            this.labelpredmet.TabIndex = 14;
            this.labelpredmet.Text = "Predmet:";
            // 
            // labelodeljenje
            // 
            this.labelodeljenje.AutoSize = true;
            this.labelodeljenje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelodeljenje.Location = new System.Drawing.Point(536, 9);
            this.labelodeljenje.Name = "labelodeljenje";
            this.labelodeljenje.Size = new System.Drawing.Size(79, 20);
            this.labelodeljenje.TabIndex = 15;
            this.labelodeljenje.Text = "Odeljenje:";
            // 
            // labelucenik
            // 
            this.labelucenik.AutoSize = true;
            this.labelucenik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelucenik.Location = new System.Drawing.Point(145, 68);
            this.labelucenik.Name = "labelucenik";
            this.labelucenik.Size = new System.Drawing.Size(62, 20);
            this.labelucenik.TabIndex = 16;
            this.labelucenik.Text = "Ucenik:";
            // 
            // labelocena
            // 
            this.labelocena.AutoSize = true;
            this.labelocena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelocena.Location = new System.Drawing.Point(275, 68);
            this.labelocena.Name = "labelocena";
            this.labelocena.Size = new System.Drawing.Size(60, 20);
            this.labelocena.TabIndex = 17;
            this.labelocena.Text = "Ocena:";
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelid.Location = new System.Drawing.Point(422, 68);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(27, 20);
            this.labelid.TabIndex = 18;
            this.labelid.Text = "Id:";
            // 
            // labeldatum
            // 
            this.labeldatum.AutoSize = true;
            this.labeldatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldatum.Location = new System.Drawing.Point(545, 68);
            this.labeldatum.Name = "labeldatum";
            this.labeldatum.Size = new System.Drawing.Size(61, 20);
            this.labeldatum.TabIndex = 19;
            this.labeldatum.Text = "Datum:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 145);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(727, 20);
            this.textBox1.TabIndex = 20;
            // 
            // Ocena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labeldatum);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.labelocena);
            this.Controls.Add(this.labelucenik);
            this.Controls.Add(this.labelodeljenje);
            this.Controls.Add(this.labelpredmet);
            this.Controls.Add(this.labelprofesor);
            this.Controls.Add(this.labelgodina);
            this.Controls.Add(this.gridocena);
            this.Controls.Add(this.buttonobrisi);
            this.Controls.Add(this.buttonizmeni);
            this.Controls.Add(this.buttondodaj);
            this.Controls.Add(this.textBoxid);
            this.Controls.Add(this.datum);
            this.Controls.Add(this.comboBoxgodina);
            this.Controls.Add(this.comboBoxodeljenje);
            this.Controls.Add(this.comboBoxpredmet);
            this.Controls.Add(this.comboBoxocena);
            this.Controls.Add(this.comboBoxucenik);
            this.Controls.Add(this.comboBoxprofesor);
            this.Name = "Ocena";
            this.Text = "Ocena";
            this.Load += new System.EventHandler(this.Ocena_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridocena)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxprofesor;
        private System.Windows.Forms.ComboBox comboBoxucenik;
        private System.Windows.Forms.ComboBox comboBoxocena;
        private System.Windows.Forms.ComboBox comboBoxpredmet;
        private System.Windows.Forms.ComboBox comboBoxodeljenje;
        private System.Windows.Forms.ComboBox comboBoxgodina;
        private System.Windows.Forms.DateTimePicker datum;
        private System.Windows.Forms.TextBox textBoxid;
        private System.Windows.Forms.Button buttondodaj;
        private System.Windows.Forms.Button buttonizmeni;
        private System.Windows.Forms.Button buttonobrisi;
        private System.Windows.Forms.DataGridView gridocena;
        private System.Windows.Forms.Label labelgodina;
        private System.Windows.Forms.Label labelprofesor;
        private System.Windows.Forms.Label labelpredmet;
        private System.Windows.Forms.Label labelodeljenje;
        private System.Windows.Forms.Label labelucenik;
        private System.Windows.Forms.Label labelocena;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Label labeldatum;
        private System.Windows.Forms.TextBox textBox1;
    }
}