
namespace DuitTracker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbBuatBaru = new System.Windows.Forms.GroupBox();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbSubtipe = new System.Windows.Forms.ComboBox();
            this.lblSubtipe = new System.Windows.Forms.Label();
            this.btnBuatTransaksi = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbTipe = new System.Windows.Forms.ComboBox();
            this.dtpTanggal = new System.Windows.Forms.DateTimePicker();
            this.tbKeterangan = new System.Windows.Forms.TextBox();
            this.tbNominal = new System.Windows.Forms.TextBox();
            this.lblTanggal = new System.Windows.Forms.Label();
            this.lblTipe = new System.Windows.Forms.Label();
            this.lblKeterangan = new System.Windows.Forms.Label();
            this.lblNominal = new System.Windows.Forms.Label();
            this.dgvSejarahTransaksi = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNilaiSaldo = new System.Windows.Forms.Label();
            this.lblNilaiTotalPengeluaran = new System.Windows.Forms.Label();
            this.lblNilaiTotalPemasukan = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblTotalPengeluaran = new System.Windows.Forms.Label();
            this.lblTotalPemasukan = new System.Windows.Forms.Label();
            this.lblBulan = new System.Windows.Forms.Label();
            this.btnBulanSebelum = new System.Windows.Forms.Button();
            this.btnBulanSetelah = new System.Windows.Forms.Button();
            this.btnKeBulanSkrgKanan = new System.Windows.Forms.Button();
            this.btnKeBulanSkrgKiri = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbBuatBaru.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSejarahTransaksi)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbBuatBaru
            // 
            this.gbBuatBaru.Controls.Add(this.btnBatal);
            this.gbBuatBaru.Controls.Add(this.btnHapus);
            this.gbBuatBaru.Controls.Add(this.panel3);
            this.gbBuatBaru.Controls.Add(this.lblSubtipe);
            this.gbBuatBaru.Controls.Add(this.btnBuatTransaksi);
            this.gbBuatBaru.Controls.Add(this.panel1);
            this.gbBuatBaru.Controls.Add(this.dtpTanggal);
            this.gbBuatBaru.Controls.Add(this.tbKeterangan);
            this.gbBuatBaru.Controls.Add(this.tbNominal);
            this.gbBuatBaru.Controls.Add(this.lblTanggal);
            this.gbBuatBaru.Controls.Add(this.lblTipe);
            this.gbBuatBaru.Controls.Add(this.lblKeterangan);
            this.gbBuatBaru.Controls.Add(this.lblNominal);
            this.gbBuatBaru.Location = new System.Drawing.Point(3, 195);
            this.gbBuatBaru.Name = "gbBuatBaru";
            this.gbBuatBaru.Size = new System.Drawing.Size(393, 150);
            this.gbBuatBaru.TabIndex = 0;
            this.gbBuatBaru.TabStop = false;
            this.gbBuatBaru.Text = "Transaksi Baru";
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(247, 115);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(64, 23);
            this.btnBatal.TabIndex = 12;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(181, 115);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(64, 23);
            this.btnHapus.TabIndex = 11;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.cmbSubtipe);
            this.panel3.Location = new System.Drawing.Point(58, 79);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(118, 21);
            this.panel3.TabIndex = 9;
            // 
            // cmbSubtipe
            // 
            this.cmbSubtipe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbSubtipe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubtipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSubtipe.FormattingEnabled = true;
            this.cmbSubtipe.Location = new System.Drawing.Point(0, 0);
            this.cmbSubtipe.Name = "cmbSubtipe";
            this.cmbSubtipe.Size = new System.Drawing.Size(116, 21);
            this.cmbSubtipe.TabIndex = 8;
            // 
            // lblSubtipe
            // 
            this.lblSubtipe.AutoSize = true;
            this.lblSubtipe.Location = new System.Drawing.Point(7, 83);
            this.lblSubtipe.Name = "lblSubtipe";
            this.lblSubtipe.Size = new System.Drawing.Size(49, 13);
            this.lblSubtipe.TabIndex = 10;
            this.lblSubtipe.Text = "Subtipe :";
            // 
            // btnBuatTransaksi
            // 
            this.btnBuatTransaksi.Location = new System.Drawing.Point(115, 115);
            this.btnBuatTransaksi.Name = "btnBuatTransaksi";
            this.btnBuatTransaksi.Size = new System.Drawing.Size(64, 23);
            this.btnBuatTransaksi.TabIndex = 9;
            this.btnBuatTransaksi.Text = "Buat";
            this.btnBuatTransaksi.UseVisualStyleBackColor = true;
            this.btnBuatTransaksi.Click += new System.EventHandler(this.btnBuatTransaksi_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmbTipe);
            this.panel1.Location = new System.Drawing.Point(58, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(118, 21);
            this.panel1.TabIndex = 2;
            // 
            // cmbTipe
            // 
            this.cmbTipe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbTipe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipe.FormattingEnabled = true;
            this.cmbTipe.Items.AddRange(new object[] {
            "Pemasukan",
            "Pengeluaran"});
            this.cmbTipe.Location = new System.Drawing.Point(0, 0);
            this.cmbTipe.Name = "cmbTipe";
            this.cmbTipe.Size = new System.Drawing.Size(116, 21);
            this.cmbTipe.TabIndex = 8;
            this.cmbTipe.SelectedIndexChanged += new System.EventHandler(this.cmbTipe_SelectedIndexChanged);
            // 
            // dtpTanggal
            // 
            this.dtpTanggal.CustomFormat = "dd-MM-yyyy";
            this.dtpTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTanggal.Location = new System.Drawing.Point(264, 77);
            this.dtpTanggal.MaxDate = new System.DateTime(2040, 12, 31, 0, 0, 0, 0);
            this.dtpTanggal.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.Size = new System.Drawing.Size(118, 20);
            this.dtpTanggal.TabIndex = 8;
            // 
            // tbKeterangan
            // 
            this.tbKeterangan.Location = new System.Drawing.Point(264, 29);
            this.tbKeterangan.Multiline = true;
            this.tbKeterangan.Name = "tbKeterangan";
            this.tbKeterangan.Size = new System.Drawing.Size(118, 42);
            this.tbKeterangan.TabIndex = 7;
            // 
            // tbNominal
            // 
            this.tbNominal.Location = new System.Drawing.Point(58, 26);
            this.tbNominal.Name = "tbNominal";
            this.tbNominal.Size = new System.Drawing.Size(118, 20);
            this.tbNominal.TabIndex = 2;
            // 
            // lblTanggal
            // 
            this.lblTanggal.AutoSize = true;
            this.lblTanggal.Location = new System.Drawing.Point(191, 83);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(52, 13);
            this.lblTanggal.TabIndex = 5;
            this.lblTanggal.Text = "Tanggal :";
            // 
            // lblTipe
            // 
            this.lblTipe.AutoSize = true;
            this.lblTipe.Location = new System.Drawing.Point(7, 56);
            this.lblTipe.Name = "lblTipe";
            this.lblTipe.Size = new System.Drawing.Size(34, 13);
            this.lblTipe.TabIndex = 4;
            this.lblTipe.Text = "Tipe :";
            // 
            // lblKeterangan
            // 
            this.lblKeterangan.AutoSize = true;
            this.lblKeterangan.Location = new System.Drawing.Point(191, 27);
            this.lblKeterangan.Name = "lblKeterangan";
            this.lblKeterangan.Size = new System.Drawing.Size(68, 13);
            this.lblKeterangan.TabIndex = 3;
            this.lblKeterangan.Text = "Keterangan :";
            // 
            // lblNominal
            // 
            this.lblNominal.AutoSize = true;
            this.lblNominal.Location = new System.Drawing.Point(6, 29);
            this.lblNominal.Name = "lblNominal";
            this.lblNominal.Size = new System.Drawing.Size(51, 13);
            this.lblNominal.TabIndex = 2;
            this.lblNominal.Text = "Nominal :";
            // 
            // dgvSejarahTransaksi
            // 
            this.dgvSejarahTransaksi.AllowUserToAddRows = false;
            this.dgvSejarahTransaksi.AllowUserToDeleteRows = false;
            this.dgvSejarahTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSejarahTransaksi.Location = new System.Drawing.Point(18, 39);
            this.dgvSejarahTransaksi.Name = "dgvSejarahTransaksi";
            this.dgvSejarahTransaksi.ReadOnly = true;
            this.dgvSejarahTransaksi.Size = new System.Drawing.Size(543, 150);
            this.dgvSejarahTransaksi.TabIndex = 1;
            this.dgvSejarahTransaksi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSejarahTransaksi_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.lblNilaiSaldo);
            this.panel2.Controls.Add(this.lblNilaiTotalPengeluaran);
            this.panel2.Controls.Add(this.lblNilaiTotalPemasukan);
            this.panel2.Controls.Add(this.lblSaldo);
            this.panel2.Controls.Add(this.lblTotalPengeluaran);
            this.panel2.Controls.Add(this.lblTotalPemasukan);
            this.panel2.Location = new System.Drawing.Point(400, 200);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(173, 72);
            this.panel2.TabIndex = 2;
            // 
            // lblNilaiSaldo
            // 
            this.lblNilaiSaldo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNilaiSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNilaiSaldo.Location = new System.Drawing.Point(99, 50);
            this.lblNilaiSaldo.Name = "lblNilaiSaldo";
            this.lblNilaiSaldo.Size = new System.Drawing.Size(64, 13);
            this.lblNilaiSaldo.TabIndex = 13;
            this.lblNilaiSaldo.Text = "0";
            this.lblNilaiSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNilaiTotalPengeluaran
            // 
            this.lblNilaiTotalPengeluaran.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNilaiTotalPengeluaran.Location = new System.Drawing.Point(99, 31);
            this.lblNilaiTotalPengeluaran.Name = "lblNilaiTotalPengeluaran";
            this.lblNilaiTotalPengeluaran.Size = new System.Drawing.Size(64, 13);
            this.lblNilaiTotalPengeluaran.TabIndex = 12;
            this.lblNilaiTotalPengeluaran.Text = "0";
            this.lblNilaiTotalPengeluaran.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNilaiTotalPemasukan
            // 
            this.lblNilaiTotalPemasukan.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNilaiTotalPemasukan.Location = new System.Drawing.Point(99, 11);
            this.lblNilaiTotalPemasukan.Name = "lblNilaiTotalPemasukan";
            this.lblNilaiTotalPemasukan.Size = new System.Drawing.Size(64, 13);
            this.lblNilaiTotalPemasukan.TabIndex = 9;
            this.lblNilaiTotalPemasukan.Text = "0";
            this.lblNilaiTotalPemasukan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(3, 50);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(47, 13);
            this.lblSaldo.TabIndex = 11;
            this.lblSaldo.Text = "Saldo :";
            // 
            // lblTotalPengeluaran
            // 
            this.lblTotalPengeluaran.AutoSize = true;
            this.lblTotalPengeluaran.Location = new System.Drawing.Point(3, 31);
            this.lblTotalPengeluaran.Name = "lblTotalPengeluaran";
            this.lblTotalPengeluaran.Size = new System.Drawing.Size(100, 13);
            this.lblTotalPengeluaran.TabIndex = 10;
            this.lblTotalPengeluaran.Text = "Total Pengeluaran :";
            // 
            // lblTotalPemasukan
            // 
            this.lblTotalPemasukan.AutoSize = true;
            this.lblTotalPemasukan.Location = new System.Drawing.Point(3, 11);
            this.lblTotalPemasukan.Name = "lblTotalPemasukan";
            this.lblTotalPemasukan.Size = new System.Drawing.Size(96, 13);
            this.lblTotalPemasukan.TabIndex = 9;
            this.lblTotalPemasukan.Text = "Total Pemasukan :";
            // 
            // lblBulan
            // 
            this.lblBulan.AutoSize = true;
            this.lblBulan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBulan.Location = new System.Drawing.Point(244, 9);
            this.lblBulan.Name = "lblBulan";
            this.lblBulan.Size = new System.Drawing.Size(80, 20);
            this.lblBulan.TabIndex = 4;
            this.lblBulan.Text = "Bulan Ini";
            // 
            // btnBulanSebelum
            // 
            this.btnBulanSebelum.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnBulanSebelum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBulanSebelum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBulanSebelum.Location = new System.Drawing.Point(225, 6);
            this.btnBulanSebelum.Name = "btnBulanSebelum";
            this.btnBulanSebelum.Size = new System.Drawing.Size(19, 29);
            this.btnBulanSebelum.TabIndex = 5;
            this.btnBulanSebelum.Text = "<";
            this.btnBulanSebelum.UseVisualStyleBackColor = true;
            this.btnBulanSebelum.Click += new System.EventHandler(this.btnBulanSebelum_Click);
            // 
            // btnBulanSetelah
            // 
            this.btnBulanSetelah.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnBulanSetelah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBulanSetelah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBulanSetelah.Location = new System.Drawing.Point(330, 6);
            this.btnBulanSetelah.Name = "btnBulanSetelah";
            this.btnBulanSetelah.Size = new System.Drawing.Size(19, 29);
            this.btnBulanSetelah.TabIndex = 6;
            this.btnBulanSetelah.Text = ">";
            this.btnBulanSetelah.UseVisualStyleBackColor = true;
            this.btnBulanSetelah.Click += new System.EventHandler(this.btnBulanSetelah_Click);
            // 
            // btnKeBulanSkrgKanan
            // 
            this.btnKeBulanSkrgKanan.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnKeBulanSkrgKanan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeBulanSkrgKanan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeBulanSkrgKanan.Location = new System.Drawing.Point(349, 6);
            this.btnKeBulanSkrgKanan.Name = "btnKeBulanSkrgKanan";
            this.btnKeBulanSkrgKanan.Size = new System.Drawing.Size(34, 29);
            this.btnKeBulanSkrgKanan.TabIndex = 7;
            this.btnKeBulanSkrgKanan.Text = ">>";
            this.btnKeBulanSkrgKanan.UseVisualStyleBackColor = true;
            this.btnKeBulanSkrgKanan.Click += new System.EventHandler(this.btnKeBulanSkrgKanan_Click);
            // 
            // btnKeBulanSkrgKiri
            // 
            this.btnKeBulanSkrgKiri.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnKeBulanSkrgKiri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeBulanSkrgKiri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeBulanSkrgKiri.Location = new System.Drawing.Point(195, 6);
            this.btnKeBulanSkrgKiri.Name = "btnKeBulanSkrgKiri";
            this.btnKeBulanSkrgKiri.Size = new System.Drawing.Size(34, 29);
            this.btnKeBulanSkrgKiri.TabIndex = 8;
            this.btnKeBulanSkrgKiri.Text = "<<";
            this.btnKeBulanSkrgKiri.UseVisualStyleBackColor = true;
            this.btnKeBulanSkrgKiri.Click += new System.EventHandler(this.btnKeBulanSkrgKiri_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(454, 279);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 66);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 350);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnKeBulanSkrgKiri);
            this.Controls.Add(this.btnKeBulanSkrgKanan);
            this.Controls.Add(this.btnBulanSetelah);
            this.Controls.Add(this.btnBulanSebelum);
            this.Controls.Add(this.lblBulan);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvSejarahTransaksi);
            this.Controls.Add(this.gbBuatBaru);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Duit Tracker";
            this.gbBuatBaru.ResumeLayout(false);
            this.gbBuatBaru.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSejarahTransaksi)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBuatBaru;
        private System.Windows.Forms.Label lblTipe;
        private System.Windows.Forms.Label lblKeterangan;
        private System.Windows.Forms.Label lblNominal;
        private System.Windows.Forms.TextBox tbKeterangan;
        private System.Windows.Forms.TextBox tbNominal;
        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.ComboBox cmbTipe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpTanggal;
        private System.Windows.Forms.DataGridView dgvSejarahTransaksi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotalPemasukan;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblTotalPengeluaran;
        private System.Windows.Forms.Button btnBuatTransaksi;
        private System.Windows.Forms.Label lblNilaiSaldo;
        private System.Windows.Forms.Label lblNilaiTotalPengeluaran;
        private System.Windows.Forms.Label lblNilaiTotalPemasukan;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cmbSubtipe;
        private System.Windows.Forms.Label lblSubtipe;
        private System.Windows.Forms.Label lblBulan;
        private System.Windows.Forms.Button btnBulanSebelum;
        private System.Windows.Forms.Button btnBulanSetelah;
        private System.Windows.Forms.Button btnKeBulanSkrgKanan;
        private System.Windows.Forms.Button btnKeBulanSkrgKiri;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

