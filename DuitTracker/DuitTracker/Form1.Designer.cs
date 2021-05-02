
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
            this.gbBuatBaru = new System.Windows.Forms.GroupBox();
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
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.gbBuatBaru.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSejarahTransaksi)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbBuatBaru
            // 
            this.gbBuatBaru.Controls.Add(this.btnBuatTransaksi);
            this.gbBuatBaru.Controls.Add(this.panel1);
            this.gbBuatBaru.Controls.Add(this.dtpTanggal);
            this.gbBuatBaru.Controls.Add(this.tbKeterangan);
            this.gbBuatBaru.Controls.Add(this.tbNominal);
            this.gbBuatBaru.Controls.Add(this.lblTanggal);
            this.gbBuatBaru.Controls.Add(this.lblTipe);
            this.gbBuatBaru.Controls.Add(this.lblKeterangan);
            this.gbBuatBaru.Controls.Add(this.lblNominal);
            this.gbBuatBaru.Location = new System.Drawing.Point(344, 97);
            this.gbBuatBaru.Name = "gbBuatBaru";
            this.gbBuatBaru.Size = new System.Drawing.Size(221, 186);
            this.gbBuatBaru.TabIndex = 0;
            this.gbBuatBaru.TabStop = false;
            this.gbBuatBaru.Text = "Transaksi Baru";
            // 
            // btnBuatTransaksi
            // 
            this.btnBuatTransaksi.Location = new System.Drawing.Point(79, 158);
            this.btnBuatTransaksi.Name = "btnBuatTransaksi";
            this.btnBuatTransaksi.Size = new System.Drawing.Size(75, 23);
            this.btnBuatTransaksi.TabIndex = 9;
            this.btnBuatTransaksi.Text = "Buat Baru";
            this.btnBuatTransaksi.UseVisualStyleBackColor = true;
            this.btnBuatTransaksi.Click += new System.EventHandler(this.btnBuatTransaksi_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmbTipe);
            this.panel1.Location = new System.Drawing.Point(86, 50);
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
            // 
            // dtpTanggal
            // 
            this.dtpTanggal.CustomFormat = "dd-MM-yyyy";
            this.dtpTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTanggal.Location = new System.Drawing.Point(86, 125);
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.Size = new System.Drawing.Size(118, 20);
            this.dtpTanggal.TabIndex = 8;
            // 
            // tbKeterangan
            // 
            this.tbKeterangan.Location = new System.Drawing.Point(86, 77);
            this.tbKeterangan.Multiline = true;
            this.tbKeterangan.Name = "tbKeterangan";
            this.tbKeterangan.Size = new System.Drawing.Size(118, 42);
            this.tbKeterangan.TabIndex = 7;
            // 
            // tbNominal
            // 
            this.tbNominal.Location = new System.Drawing.Point(86, 24);
            this.tbNominal.Name = "tbNominal";
            this.tbNominal.Size = new System.Drawing.Size(118, 20);
            this.tbNominal.TabIndex = 2;
            // 
            // lblTanggal
            // 
            this.lblTanggal.AutoSize = true;
            this.lblTanggal.Location = new System.Drawing.Point(13, 131);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(52, 13);
            this.lblTanggal.TabIndex = 5;
            this.lblTanggal.Text = "Tanggal :";
            // 
            // lblTipe
            // 
            this.lblTipe.AutoSize = true;
            this.lblTipe.Location = new System.Drawing.Point(13, 54);
            this.lblTipe.Name = "lblTipe";
            this.lblTipe.Size = new System.Drawing.Size(34, 13);
            this.lblTipe.TabIndex = 4;
            this.lblTipe.Text = "Tipe :";
            // 
            // lblKeterangan
            // 
            this.lblKeterangan.AutoSize = true;
            this.lblKeterangan.Location = new System.Drawing.Point(13, 75);
            this.lblKeterangan.Name = "lblKeterangan";
            this.lblKeterangan.Size = new System.Drawing.Size(68, 13);
            this.lblKeterangan.TabIndex = 3;
            this.lblKeterangan.Text = "Keterangan :";
            // 
            // lblNominal
            // 
            this.lblNominal.AutoSize = true;
            this.lblNominal.Location = new System.Drawing.Point(12, 27);
            this.lblNominal.Name = "lblNominal";
            this.lblNominal.Size = new System.Drawing.Size(51, 13);
            this.lblNominal.TabIndex = 2;
            this.lblNominal.Text = "Nominal :";
            // 
            // dgvSejarahTransaksi
            // 
            this.dgvSejarahTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSejarahTransaksi.Location = new System.Drawing.Point(12, 112);
            this.dgvSejarahTransaksi.Name = "dgvSejarahTransaksi";
            this.dgvSejarahTransaksi.Size = new System.Drawing.Size(326, 150);
            this.dgvSejarahTransaksi.TabIndex = 1;
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
            this.panel2.Location = new System.Drawing.Point(344, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(221, 72);
            this.panel2.TabIndex = 2;
            // 
            // lblNilaiSaldo
            // 
            this.lblNilaiSaldo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNilaiSaldo.Location = new System.Drawing.Point(140, 50);
            this.lblNilaiSaldo.Name = "lblNilaiSaldo";
            this.lblNilaiSaldo.Size = new System.Drawing.Size(64, 13);
            this.lblNilaiSaldo.TabIndex = 13;
            this.lblNilaiSaldo.Text = "0";
            this.lblNilaiSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNilaiTotalPengeluaran
            // 
            this.lblNilaiTotalPengeluaran.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNilaiTotalPengeluaran.Location = new System.Drawing.Point(139, 31);
            this.lblNilaiTotalPengeluaran.Name = "lblNilaiTotalPengeluaran";
            this.lblNilaiTotalPengeluaran.Size = new System.Drawing.Size(64, 13);
            this.lblNilaiTotalPengeluaran.TabIndex = 12;
            this.lblNilaiTotalPengeluaran.Text = "0";
            this.lblNilaiTotalPengeluaran.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNilaiTotalPemasukan
            // 
            this.lblNilaiTotalPemasukan.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNilaiTotalPemasukan.Location = new System.Drawing.Point(139, 11);
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
            this.lblSaldo.Location = new System.Drawing.Point(14, 50);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(47, 13);
            this.lblSaldo.TabIndex = 11;
            this.lblSaldo.Text = "Saldo :";
            // 
            // lblTotalPengeluaran
            // 
            this.lblTotalPengeluaran.AutoSize = true;
            this.lblTotalPengeluaran.Location = new System.Drawing.Point(14, 31);
            this.lblTotalPengeluaran.Name = "lblTotalPengeluaran";
            this.lblTotalPengeluaran.Size = new System.Drawing.Size(100, 13);
            this.lblTotalPengeluaran.TabIndex = 10;
            this.lblTotalPengeluaran.Text = "Total Pengeluaran :";
            // 
            // lblTotalPemasukan
            // 
            this.lblTotalPemasukan.AutoSize = true;
            this.lblTotalPemasukan.Location = new System.Drawing.Point(14, 11);
            this.lblTotalPemasukan.Name = "lblTotalPemasukan";
            this.lblTotalPemasukan.Size = new System.Drawing.Size(96, 13);
            this.lblTotalPemasukan.TabIndex = 9;
            this.lblTotalPemasukan.Text = "Total Pemasukan :";
            // 
            // gbFilter
            // 
            this.gbFilter.Location = new System.Drawing.Point(12, 6);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(326, 69);
            this.gbFilter.TabIndex = 3;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 295);
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvSejarahTransaksi);
            this.Controls.Add(this.gbBuatBaru);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbBuatBaru.ResumeLayout(false);
            this.gbBuatBaru.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSejarahTransaksi)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Button btnBuatTransaksi;
        private System.Windows.Forms.Label lblNilaiSaldo;
        private System.Windows.Forms.Label lblNilaiTotalPengeluaran;
        private System.Windows.Forms.Label lblNilaiTotalPemasukan;
    }
}

