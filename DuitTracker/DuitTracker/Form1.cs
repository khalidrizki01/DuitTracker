using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DuitTrackerLib;
using System.Data.SqlClient;

namespace DuitTracker
{
    public partial class Form1 : Form
    {
        //string path = "Server = DESKTOP-KI75MOF;Database = DuitTrackerDB ;Integrated Security = True";

        string path = @"data source=(LocalDB)\MSSQLLocalDB;attachdbfilename=|DataDirectory|\DuitDB.mdf;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable tabel;
        Transaksi transaksi;
        DateTime today, currentView;
        enum Mode { Buat, Edit}
        Mode mode;
        public Form1()
        {
            InitializeComponent();
            currentView = today =  DateTime.Today;
            //conn = new SqlConnection(path);
            DisplayDataGridView();
            btnKeBulanSkrgKiri.Enabled = false;
            btnKeBulanSkrgKanan.Enabled = false;
            btnHapus.Enabled = false;
            mode = Mode.Buat;
            //DisplaySaldo();
        }

        private void btnBuatTransaksi_Click(object sender, EventArgs e)
        {
            if (mode == Mode.Buat)
            {
                BuatTransaksi();
            }
            else if (mode == Mode.Edit)
            {
                EditTransaksi();
            }
        }
        private void Clear()
        {
            tbNominal.Text = "";
            cmbTipe.SelectedIndex = -1;
            cmbSubtipe.SelectedIndex = -1;
            tbKeterangan.Text = "";
            dtpTanggal.Value = today;
        }
        private void DisplayDataGridView()
        {
            try
            {
                string sqlYearMonth = GetSqlYearMonth();
                
                tabel = new DataTable();
                using (conn = new SqlConnection(path))
                {
                    string query = string.Format("SELECT Id, Nominal, Subtipe, Keterangan, Tanggal FROM Transaksi WHERE Tanggal LIKE '{0}%' ORDER BY Tanggal DESC", sqlYearMonth);
                    adapter = new SqlDataAdapter(query, conn);
                    adapter.Fill(tabel);
                    dgvSejarahTransaksi.DataSource = tabel;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //foreach (DataGridViewRow row in dgvSejarahTransaksi.Rows)
            //{
            //    try
            //    {
            //        Color color;
            //        int id = (int)row.Cells[0].Value;
            //        using (var db = new DuitDBModel())
            //        {
            //            var getTipe = db.Transaksis.SingleOrDefault(item => item.Id == id);
            //            string warna = ConvertTipeKeWarna(getTipe.Tipe);
            //            color = ColorTranslator.FromHtml(warna);
            //        }
            //        row.DefaultCellStyle.BackColor = color;
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //}
        }
        private void DisplaySaldo()
        {
            try
            {
                conn.Open();
                DataTable totalPemasukan = new DataTable();
                DataTable totalPengeluaran = new DataTable();

                adapter = new SqlDataAdapter("SELECT SUM(Nominal) FROM Transaksi WHERE Tipe = 'Pemasukan'", conn);
                adapter.Fill(totalPemasukan);
                lblNilaiTotalPemasukan.Text = totalPemasukan.Rows[0][0].ToString();

                adapter = new SqlDataAdapter("SELECT SUM(Nominal) FROM Transaksi WHERE Tipe = 'Pengeluaran'", conn);
                adapter.Fill(totalPengeluaran);
                lblNilaiTotalPengeluaran.Text = totalPengeluaran.Rows[0][0].ToString();

                lblNilaiSaldo.Text = (int.Parse(lblNilaiTotalPemasukan.Text) - int.Parse(lblNilaiTotalPengeluaran.Text)).ToString();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BuatTransaksi()
        {
            if (tbNominal.Text != "" || cmbTipe.Text != "" ||cmbSubtipe.Text !="" || dtpTanggal.Value.ToString() != "")
            {
                try
                {
                    using(var db = new DuitDBModel())
                    {
                        transaksi = new Transaksi()
                        {
                            Nominal = int.Parse(tbNominal.Text),
                            Tipe = cmbTipe.SelectedIndex,
                            Subtipe = cmbSubtipe.Text,
                            Tanggal = dtpTanggal.Value.Date,
                        };
                        db.Transaksis.Add(transaksi);
                        db.SaveChanges();
                    }
                    DisplayControls();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Kolom Nominal, Tipe, Subtipe dan Tanggal harus terisi");
            }
        }

        private void EditTransaksi()
        {
            if (tbNominal.Text != "" || cmbTipe.Text != "" || cmbSubtipe.Text != "" || dtpTanggal.Value.ToString() != "")
            {
                try
                {
                    using (var db = new DuitDBModel())
                    {
                        var updatean = db.Transaksis.SingleOrDefault(item => item.Id == transaksi.Id);

                        updatean.Nominal = int.Parse(tbNominal.Text);
                        updatean.Tipe = cmbTipe.SelectedIndex;
                        updatean.Subtipe = cmbSubtipe.Text;
                        updatean.Keterangan = tbKeterangan.Text;
                        updatean.Tanggal = dtpTanggal.Value;
                        db.SaveChanges();
                    }
                    DisplayControls();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Kolom Nominal, Tipe, Subtipe, dan Tanggal harus terisi");
            }
        }

        private void HapusTransaksi()
        {
            try
            {
                using(var db = new DuitDBModel())
                {
                    db.Transaksis.RemoveRange(db.Transaksis.Where(item => item.Id == transaksi.Id));
                    db.SaveChanges();
                }
                DisplayControls();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DisplayControls()
        {
            Clear();
            DisplayDataGridView();
            //DisplaySaldo();
        }

        private string ConvertTipeKeWarna(int tipe)
        {
            if (tipe == 0)
                return "#55efc4";
            else
                return "#ff7675";
        }

        private void btnBulanSetelah_Click(object sender, EventArgs e)
        {
            currentView = currentView.AddMonths(1);
            lblBulan.Text = currentView.ToString("MMM, yyyy");
            btnKeBulanSkrgKiri.Enabled = true;
            DisplayControls();
        }

        private void btnKeBulanSkrgKiri_Click(object sender, EventArgs e)
        {
            currentView = today;
            lblBulan.Text = currentView.ToString("MMM, yyyy");
            btnKeBulanSkrgKiri.Enabled = false;
            DisplayControls();
        }

        private void btnKeBulanSkrgKanan_Click(object sender, EventArgs e)
        {
            currentView = today;
            lblBulan.Text = currentView.ToString("MMM, yyyy");
            btnKeBulanSkrgKanan.Enabled = false;
            DisplayControls();
        }

        private void dgvSejarahTransaksi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dgvSejarahTransaksi.Rows[e.RowIndex].Cells[0].Value;
            using (var db = new DuitDBModel())
            {
                var transaksiTerpilih = db.Transaksis.SingleOrDefault(item => item.Id == id);
                transaksi = new Transaksi()
                {
                    Id = id,
                    Nominal = transaksiTerpilih.Nominal,
                    Tipe = transaksiTerpilih.Tipe,
                    Subtipe = transaksiTerpilih.Subtipe,
                    Tanggal = transaksiTerpilih.Tanggal
                };
            }
            tbNominal.Text = transaksi.Nominal.ToString();
            cmbTipe.SelectedIndex = transaksi.Tipe;
            cmbSubtipe.SelectedItem = transaksi.Subtipe;
            tbKeterangan.Text = transaksi.Keterangan;
            dtpTanggal.Value = transaksi.Tanggal;

            mode = Mode.Edit;
            btnBuatTransaksi.Text = "Edit";
            btnHapus.Enabled = true;
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            HapusTransaksi();
        }

        private void btnBulanSebelum_Click(object sender, EventArgs e)
        {
            currentView = currentView.AddMonths(-1);
            lblBulan.Text = currentView.ToString("MMM, yyyy");
            btnKeBulanSkrgKanan.Enabled = true;
            DisplayControls();
        }

        private string GetSqlYearMonth()
        {
            string month = currentView.Month.ToString();
            if (month.Length == 1)
                month = "0" + month;
            string year = currentView.Year.ToString();

            return year + "-" + month;
        }
    }
}
