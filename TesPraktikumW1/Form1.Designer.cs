namespace TesPraktikumW1
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
            this.TambahBuahBtn = new System.Windows.Forms.RadioButton();
            this.TransaksiBtn = new System.Windows.Forms.RadioButton();
            this.TambahBuahGroup = new System.Windows.Forms.GroupBox();
            this.InputHarga = new System.Windows.Forms.TextBox();
            this.InputKategori = new System.Windows.Forms.TextBox();
            this.NamaBuah = new System.Windows.Forms.TextBox();
            this.TambahBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Buah = new System.Windows.Forms.ListBox();
            this.GroupTransaksi = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.History = new System.Windows.Forms.ListBox();
            this.Keranjang = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AddtoCartbtn = new System.Windows.Forms.Button();
            this.beratTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BuahComboBox = new System.Windows.Forms.ComboBox();
            this.TambahBuahGroup.SuspendLayout();
            this.GroupTransaksi.SuspendLayout();
            this.SuspendLayout();
            // 
            // TambahBuahBtn
            // 
            this.TambahBuahBtn.AccessibleDescription = "Button to enable tambah buah mode.";
            this.TambahBuahBtn.AccessibleName = "TambahBuahBtn";
            this.TambahBuahBtn.AutoSize = true;
            this.TambahBuahBtn.Location = new System.Drawing.Point(27, 22);
            this.TambahBuahBtn.Name = "TambahBuahBtn";
            this.TambahBuahBtn.Size = new System.Drawing.Size(92, 17);
            this.TambahBuahBtn.TabIndex = 0;
            this.TambahBuahBtn.TabStop = true;
            this.TambahBuahBtn.Text = "Tambah Buah";
            this.TambahBuahBtn.UseVisualStyleBackColor = true;
            this.TambahBuahBtn.CheckedChanged += new System.EventHandler(this.TambahBuahBtn_CheckedChanged);
            this.TambahBuahBtn.Click += new System.EventHandler(this.TambahBuahBtn_Click);
            // 
            // TransaksiBtn
            // 
            this.TransaksiBtn.AccessibleDescription = "Button to enable transaksi mode.";
            this.TransaksiBtn.AccessibleName = "TransaksiBtn";
            this.TransaksiBtn.AutoSize = true;
            this.TransaksiBtn.Location = new System.Drawing.Point(125, 22);
            this.TransaksiBtn.Name = "TransaksiBtn";
            this.TransaksiBtn.Size = new System.Drawing.Size(71, 17);
            this.TransaksiBtn.TabIndex = 1;
            this.TransaksiBtn.TabStop = true;
            this.TransaksiBtn.Text = "Transaksi";
            this.TransaksiBtn.UseVisualStyleBackColor = true;
            this.TransaksiBtn.CheckedChanged += new System.EventHandler(this.TransaksiBtn_CheckedChanged);
            // 
            // TambahBuahGroup
            // 
            this.TambahBuahGroup.AccessibleDescription = "Tambah Buah Group Box";
            this.TambahBuahGroup.AccessibleName = "TambahBuahGroup";
            this.TambahBuahGroup.Controls.Add(this.InputHarga);
            this.TambahBuahGroup.Controls.Add(this.InputKategori);
            this.TambahBuahGroup.Controls.Add(this.NamaBuah);
            this.TambahBuahGroup.Controls.Add(this.TambahBtn);
            this.TambahBuahGroup.Controls.Add(this.label3);
            this.TambahBuahGroup.Controls.Add(this.label2);
            this.TambahBuahGroup.Controls.Add(this.label1);
            this.TambahBuahGroup.Enabled = false;
            this.TambahBuahGroup.Location = new System.Drawing.Point(12, 55);
            this.TambahBuahGroup.Name = "TambahBuahGroup";
            this.TambahBuahGroup.Size = new System.Drawing.Size(226, 142);
            this.TambahBuahGroup.TabIndex = 2;
            this.TambahBuahGroup.TabStop = false;
            this.TambahBuahGroup.Text = "Tambah Buah";
            // 
            // InputHarga
            // 
            this.InputHarga.Location = new System.Drawing.Point(87, 82);
            this.InputHarga.Name = "InputHarga";
            this.InputHarga.Size = new System.Drawing.Size(133, 20);
            this.InputHarga.TabIndex = 3;
            // 
            // InputKategori
            // 
            this.InputKategori.Location = new System.Drawing.Point(87, 55);
            this.InputKategori.Name = "InputKategori";
            this.InputKategori.Size = new System.Drawing.Size(133, 20);
            this.InputKategori.TabIndex = 3;
            // 
            // NamaBuah
            // 
            this.NamaBuah.Location = new System.Drawing.Point(87, 26);
            this.NamaBuah.Name = "NamaBuah";
            this.NamaBuah.Size = new System.Drawing.Size(133, 20);
            this.NamaBuah.TabIndex = 3;
            // 
            // TambahBtn
            // 
            this.TambahBtn.AccessibleDescription = "Activated Tambah Button in Tambah Buah Group";
            this.TambahBtn.AccessibleName = "TambahBtn";
            this.TambahBtn.Location = new System.Drawing.Point(6, 108);
            this.TambahBtn.Name = "TambahBtn";
            this.TambahBtn.Size = new System.Drawing.Size(214, 28);
            this.TambahBtn.TabIndex = 6;
            this.TambahBtn.Text = "Tambah";
            this.TambahBtn.UseVisualStyleBackColor = true;
            this.TambahBtn.Click += new System.EventHandler(this.TambahBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Harga per Kg :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kategori :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nama Buah :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "List Buah :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Buah
            // 
            this.Buah.AccessibleDescription = "List for added \"Buah\"";
            this.Buah.AccessibleName = "ListBuah";
            this.Buah.Enabled = false;
            this.Buah.FormattingEnabled = true;
            this.Buah.Location = new System.Drawing.Point(13, 221);
            this.Buah.Name = "Buah";
            this.Buah.Size = new System.Drawing.Size(225, 212);
            this.Buah.TabIndex = 5;
            // 
            // GroupTransaksi
            // 
            this.GroupTransaksi.Controls.Add(this.label8);
            this.GroupTransaksi.Controls.Add(this.History);
            this.GroupTransaksi.Controls.Add(this.Keranjang);
            this.GroupTransaksi.Controls.Add(this.label7);
            this.GroupTransaksi.Controls.Add(this.AddtoCartbtn);
            this.GroupTransaksi.Controls.Add(this.beratTextBox);
            this.GroupTransaksi.Controls.Add(this.label6);
            this.GroupTransaksi.Controls.Add(this.label5);
            this.GroupTransaksi.Controls.Add(this.BuahComboBox);
            this.GroupTransaksi.Location = new System.Drawing.Point(255, 22);
            this.GroupTransaksi.Name = "GroupTransaksi";
            this.GroupTransaksi.Size = new System.Drawing.Size(533, 411);
            this.GroupTransaksi.TabIndex = 6;
            this.GroupTransaksi.TabStop = false;
            this.GroupTransaksi.Text = "Transaksi";
            this.GroupTransaksi.Enter += new System.EventHandler(this.GroupTransaksi_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(266, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "History Transaksi";
            // 
            // History
            // 
            this.History.FormattingEnabled = true;
            this.History.Location = new System.Drawing.Point(266, 35);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(261, 355);
            this.History.TabIndex = 7;
            // 
            // Keranjang
            // 
            this.Keranjang.FormattingEnabled = true;
            this.Keranjang.Location = new System.Drawing.Point(12, 141);
            this.Keranjang.Name = "Keranjang";
            this.Keranjang.Size = new System.Drawing.Size(248, 251);
            this.Keranjang.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Keranjang :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // AddtoCartbtn
            // 
            this.AddtoCartbtn.Location = new System.Drawing.Point(12, 81);
            this.AddtoCartbtn.Name = "AddtoCartbtn";
            this.AddtoCartbtn.Size = new System.Drawing.Size(248, 23);
            this.AddtoCartbtn.TabIndex = 4;
            this.AddtoCartbtn.Text = "Tambah ke Keranjang";
            this.AddtoCartbtn.UseVisualStyleBackColor = true;
            // 
            // beratTextBox
            // 
            this.beratTextBox.Location = new System.Drawing.Point(99, 48);
            this.beratTextBox.Name = "beratTextBox";
            this.beratTextBox.Size = new System.Drawing.Size(161, 20);
            this.beratTextBox.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Berat (dalam kg) :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Buah :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // BuahComboBox
            // 
            this.BuahComboBox.FormattingEnabled = true;
            this.BuahComboBox.Location = new System.Drawing.Point(99, 19);
            this.BuahComboBox.Name = "BuahComboBox";
            this.BuahComboBox.Size = new System.Drawing.Size(161, 21);
            this.BuahComboBox.TabIndex = 0;
            this.BuahComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GroupTransaksi);
            this.Controls.Add(this.Buah);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TambahBuahGroup);
            this.Controls.Add(this.TransaksiBtn);
            this.Controls.Add(this.TambahBuahBtn);
            this.Name = "Form1";
            this.Text = "`";
            this.Click += new System.EventHandler(this.Form1_Click);
            this.TambahBuahGroup.ResumeLayout(false);
            this.TambahBuahGroup.PerformLayout();
            this.GroupTransaksi.ResumeLayout(false);
            this.GroupTransaksi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton TambahBuahBtn;
        private System.Windows.Forms.RadioButton TransaksiBtn;
        private System.Windows.Forms.GroupBox TambahBuahGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputHarga;
        private System.Windows.Forms.TextBox InputKategori;
        private System.Windows.Forms.TextBox NamaBuah;
        private System.Windows.Forms.Button TambahBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox Buah;
        private System.Windows.Forms.GroupBox GroupTransaksi;
        private System.Windows.Forms.ComboBox BuahComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox beratTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AddtoCartbtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox Keranjang;
        private System.Windows.Forms.ListBox History;
        private System.Windows.Forms.Label label8;
    }
}

