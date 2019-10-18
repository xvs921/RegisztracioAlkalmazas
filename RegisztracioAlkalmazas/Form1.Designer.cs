namespace RegisztracioAlkalmazas
{
    partial class Form1
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
            this.textBoxNev = new System.Windows.Forms.TextBox();
            this.lblNev = new System.Windows.Forms.Label();
            this.lblSzulDatum = new System.Windows.Forms.Label();
            this.textBoxSzulDatum = new System.Windows.Forms.TextBox();
            this.lblNem = new System.Windows.Forms.Label();
            this.radioButtonFerfi = new System.Windows.Forms.RadioButton();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.lblKedvencHobbi = new System.Windows.Forms.Label();
            this.listBoxHobbik = new System.Windows.Forms.ListBox();
            this.lblUjHobbi = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnHozzaad = new System.Windows.Forms.Button();
            this.btnBetoltes = new System.Windows.Forms.Button();
            this.btnMentes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNev
            // 
            this.textBoxNev.Location = new System.Drawing.Point(150, 42);
            this.textBoxNev.Name = "textBoxNev";
            this.textBoxNev.Size = new System.Drawing.Size(100, 20);
            this.textBoxNev.TabIndex = 0;
            // 
            // lblNev
            // 
            this.lblNev.AutoSize = true;
            this.lblNev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNev.Location = new System.Drawing.Point(40, 42);
            this.lblNev.Name = "lblNev";
            this.lblNev.Size = new System.Drawing.Size(40, 20);
            this.lblNev.TabIndex = 1;
            this.lblNev.Text = "Név:";
            // 
            // lblSzulDatum
            // 
            this.lblSzulDatum.AutoSize = true;
            this.lblSzulDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSzulDatum.Location = new System.Drawing.Point(40, 83);
            this.lblSzulDatum.Name = "lblSzulDatum";
            this.lblSzulDatum.Size = new System.Drawing.Size(97, 20);
            this.lblSzulDatum.TabIndex = 2;
            this.lblSzulDatum.Text = "Szül. dátum:";
            // 
            // textBoxSzulDatum
            // 
            this.textBoxSzulDatum.Location = new System.Drawing.Point(150, 85);
            this.textBoxSzulDatum.Name = "textBoxSzulDatum";
            this.textBoxSzulDatum.Size = new System.Drawing.Size(100, 20);
            this.textBoxSzulDatum.TabIndex = 3;
            // 
            // lblNem
            // 
            this.lblNem.AutoSize = true;
            this.lblNem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNem.Location = new System.Drawing.Point(40, 130);
            this.lblNem.Name = "lblNem";
            this.lblNem.Size = new System.Drawing.Size(46, 20);
            this.lblNem.TabIndex = 5;
            this.lblNem.Text = "Nem:";
            // 
            // radioButtonFerfi
            // 
            this.radioButtonFerfi.AutoSize = true;
            this.radioButtonFerfi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonFerfi.Location = new System.Drawing.Point(150, 128);
            this.radioButtonFerfi.Name = "radioButtonFerfi";
            this.radioButtonFerfi.Size = new System.Drawing.Size(37, 24);
            this.radioButtonFerfi.TabIndex = 6;
            this.radioButtonFerfi.TabStop = true;
            this.radioButtonFerfi.Text = "F";
            this.radioButtonFerfi.UseVisualStyleBackColor = true;
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonNo.Location = new System.Drawing.Point(212, 128);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(38, 24);
            this.radioButtonNo.TabIndex = 7;
            this.radioButtonNo.TabStop = true;
            this.radioButtonNo.Text = "N";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            // 
            // lblKedvencHobbi
            // 
            this.lblKedvencHobbi.AutoSize = true;
            this.lblKedvencHobbi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKedvencHobbi.Location = new System.Drawing.Point(283, 40);
            this.lblKedvencHobbi.Name = "lblKedvencHobbi";
            this.lblKedvencHobbi.Size = new System.Drawing.Size(117, 20);
            this.lblKedvencHobbi.TabIndex = 8;
            this.lblKedvencHobbi.Text = "Kedvenc hobbi:";
            // 
            // listBoxHobbik
            // 
            this.listBoxHobbik.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxHobbik.FormattingEnabled = true;
            this.listBoxHobbik.ItemHeight = 18;
            this.listBoxHobbik.Items.AddRange(new object[] {
            "Uszás",
            "Horgászat",
            "Futás"});
            this.listBoxHobbik.Location = new System.Drawing.Point(287, 63);
            this.listBoxHobbik.Name = "listBoxHobbik";
            this.listBoxHobbik.Size = new System.Drawing.Size(120, 94);
            this.listBoxHobbik.TabIndex = 9;
            // 
            // lblUjHobbi
            // 
            this.lblUjHobbi.AutoSize = true;
            this.lblUjHobbi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUjHobbi.Location = new System.Drawing.Point(208, 173);
            this.lblUjHobbi.Name = "lblUjHobbi";
            this.lblUjHobbi.Size = new System.Drawing.Size(71, 20);
            this.lblUjHobbi.TabIndex = 10;
            this.lblUjHobbi.Text = "Új hobbi:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(287, 175);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(120, 20);
            this.textBox3.TabIndex = 11;
            // 
            // btnHozzaad
            // 
            this.btnHozzaad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHozzaad.Location = new System.Drawing.Point(311, 201);
            this.btnHozzaad.Name = "btnHozzaad";
            this.btnHozzaad.Size = new System.Drawing.Size(96, 27);
            this.btnHozzaad.TabIndex = 12;
            this.btnHozzaad.Text = "Hozzáad";
            this.btnHozzaad.UseVisualStyleBackColor = true;
            // 
            // btnBetoltes
            // 
            this.btnBetoltes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBetoltes.Location = new System.Drawing.Point(325, 248);
            this.btnBetoltes.Name = "btnBetoltes";
            this.btnBetoltes.Size = new System.Drawing.Size(82, 31);
            this.btnBetoltes.TabIndex = 13;
            this.btnBetoltes.Text = "Betöltés";
            this.btnBetoltes.UseVisualStyleBackColor = true;
            // 
            // btnMentes
            // 
            this.btnMentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMentes.Location = new System.Drawing.Point(231, 248);
            this.btnMentes.Name = "btnMentes";
            this.btnMentes.Size = new System.Drawing.Size(75, 31);
            this.btnMentes.TabIndex = 14;
            this.btnMentes.Text = "Mentés";
            this.btnMentes.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 324);
            this.Controls.Add(this.btnMentes);
            this.Controls.Add(this.btnBetoltes);
            this.Controls.Add(this.btnHozzaad);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lblUjHobbi);
            this.Controls.Add(this.listBoxHobbik);
            this.Controls.Add(this.lblKedvencHobbi);
            this.Controls.Add(this.radioButtonNo);
            this.Controls.Add(this.radioButtonFerfi);
            this.Controls.Add(this.lblNem);
            this.Controls.Add(this.textBoxSzulDatum);
            this.Controls.Add(this.lblSzulDatum);
            this.Controls.Add(this.lblNev);
            this.Controls.Add(this.textBoxNev);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNev;
        private System.Windows.Forms.Label lblNev;
        private System.Windows.Forms.Label lblSzulDatum;
        private System.Windows.Forms.TextBox textBoxSzulDatum;
        private System.Windows.Forms.Label lblNem;
        private System.Windows.Forms.RadioButton radioButtonFerfi;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.Label lblKedvencHobbi;
        private System.Windows.Forms.ListBox listBoxHobbik;
        private System.Windows.Forms.Label lblUjHobbi;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnHozzaad;
        private System.Windows.Forms.Button btnBetoltes;
        private System.Windows.Forms.Button btnMentes;
    }
}

