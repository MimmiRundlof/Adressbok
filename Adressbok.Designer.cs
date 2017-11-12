namespace Adressbok
{
    partial class Adressbok
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
            this.AdressbokDataGridView = new System.Windows.Forms.DataGridView();
            this.Namn = new System.Windows.Forms.Label();
            this.tbNamn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPostort = new System.Windows.Forms.TextBox();
            this.tbPostnummer = new System.Windows.Forms.TextBox();
            this.tbGatuadress = new System.Windows.Forms.TextBox();
            this.tbEpost = new System.Windows.Forms.TextBox();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbKontakttyp = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbSok = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Editbutton = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AdressbokDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AdressbokDataGridView
            // 
            this.AdressbokDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdressbokDataGridView.Location = new System.Drawing.Point(143, 40);
            this.AdressbokDataGridView.Name = "AdressbokDataGridView";
            this.AdressbokDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AdressbokDataGridView.Size = new System.Drawing.Size(846, 232);
            this.AdressbokDataGridView.TabIndex = 0;
            this.AdressbokDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AdressbokDataGridView_CellClick);
            // 
            // Namn
            // 
            this.Namn.AutoSize = true;
            this.Namn.Location = new System.Drawing.Point(13, 24);
            this.Namn.Name = "Namn";
            this.Namn.Size = new System.Drawing.Size(35, 13);
            this.Namn.TabIndex = 1;
            this.Namn.Text = "Namn";
            // 
            // tbNamn
            // 
            this.tbNamn.Location = new System.Drawing.Point(16, 40);
            this.tbNamn.Name = "tbNamn";
            this.tbNamn.Size = new System.Drawing.Size(121, 20);
            this.tbNamn.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Telefon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Postnummer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gatuadress";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Epost";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Postort";
            // 
            // tbPostort
            // 
            this.tbPostort.Location = new System.Drawing.Point(16, 235);
            this.tbPostort.Name = "tbPostort";
            this.tbPostort.Size = new System.Drawing.Size(121, 20);
            this.tbPostort.TabIndex = 6;
            // 
            // tbPostnummer
            // 
            this.tbPostnummer.Location = new System.Drawing.Point(16, 196);
            this.tbPostnummer.Name = "tbPostnummer";
            this.tbPostnummer.Size = new System.Drawing.Size(121, 20);
            this.tbPostnummer.TabIndex = 5;
            // 
            // tbGatuadress
            // 
            this.tbGatuadress.Location = new System.Drawing.Point(16, 157);
            this.tbGatuadress.Name = "tbGatuadress";
            this.tbGatuadress.Size = new System.Drawing.Size(121, 20);
            this.tbGatuadress.TabIndex = 4;
            // 
            // tbEpost
            // 
            this.tbEpost.Location = new System.Drawing.Point(16, 118);
            this.tbEpost.Name = "tbEpost";
            this.tbEpost.Size = new System.Drawing.Size(121, 20);
            this.tbEpost.TabIndex = 3;
            // 
            // tbTelefon
            // 
            this.tbTelefon.Location = new System.Drawing.Point(16, 79);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(121, 20);
            this.tbTelefon.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Kontakttyp";
            // 
            // cmbKontakttyp
            // 
            this.cmbKontakttyp.FormattingEnabled = true;
            this.cmbKontakttyp.Items.AddRange(new object[] {
            "Personlig",
            "Jobb",
            "Övrig"});
            this.cmbKontakttyp.Location = new System.Drawing.Point(16, 275);
            this.cmbKontakttyp.Name = "cmbKontakttyp";
            this.cmbKontakttyp.Size = new System.Drawing.Size(121, 21);
            this.cmbKontakttyp.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Skapa ny";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CreateNewPersonButton_Click);
            // 
            // tbSok
            // 
            this.tbSok.Location = new System.Drawing.Point(770, 281);
            this.tbSok.Name = "tbSok";
            this.tbSok.Size = new System.Drawing.Size(219, 20);
            this.tbSok.TabIndex = 16;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(677, 279);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 23);
            this.button4.TabIndex = 21;
            this.button4.Text = "Sök";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Search_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(143, 279);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 23);
            this.button5.TabIndex = 22;
            this.button5.Text = "Uppdatera";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Updatebutton_Click);
            // 
            // Editbutton
            // 
            this.Editbutton.Location = new System.Drawing.Point(16, 331);
            this.Editbutton.Name = "Editbutton";
            this.Editbutton.Size = new System.Drawing.Size(121, 23);
            this.Editbutton.TabIndex = 24;
            this.Editbutton.Text = "Ändra befintlig";
            this.Editbutton.UseVisualStyleBackColor = true;
            this.Editbutton.Click += new System.EventHandler(this.Editbutton_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(16, 360);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(121, 23);
            this.button6.TabIndex = 25;
            this.button6.Text = "Ta bort";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // Adressbok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 408);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.Editbutton);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.tbSok);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbKontakttyp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbTelefon);
            this.Controls.Add(this.tbEpost);
            this.Controls.Add(this.tbGatuadress);
            this.Controls.Add(this.tbPostnummer);
            this.Controls.Add(this.tbPostort);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNamn);
            this.Controls.Add(this.Namn);
            this.Controls.Add(this.AdressbokDataGridView);
            this.Name = "Adressbok";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.AdressbokDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AdressbokDataGridView;
        private System.Windows.Forms.Label Namn;
        private System.Windows.Forms.TextBox tbNamn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPostort;
        private System.Windows.Forms.TextBox tbPostnummer;
        private System.Windows.Forms.TextBox tbGatuadress;
        private System.Windows.Forms.TextBox tbEpost;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbKontakttyp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbSok;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button Editbutton;
        private System.Windows.Forms.Button button6;
    }
}

