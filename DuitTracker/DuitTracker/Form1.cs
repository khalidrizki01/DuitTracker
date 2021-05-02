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
        string path = "Server = DESKTOP-KI75MOF;Database = DuitTrackerDB ;Integrated Security = True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable tabel;
        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection(path);
            DisplayDataGridView();
            DisplaySaldo();
        }

        private void btnBuatTransaksi_Click(object sender, EventArgs e)
        {
            if (tbNominal.Text == "" || cmbTipe.Text == "" || dtpTanggal.Value.ToString() == "")
                MessageBox.Show("Kolom Nominal, Tipe, dan Tanggal harus terisi");
            try
            {
                Transaksi transaksi = new Transaksi(int.Parse(tbNominal.Text), cmbTipe.Text, tbKeterangan.Text, dtpTanggal.Value);
                               
                con.Open();
                cmd = new SqlCommand("INSERT INTO Transaksi VALUES('" + tbNominal.Text + "','" + cmbTipe.Text + "','" + tbKeterangan.Text + "','" + dtpTanggal.Value.ToString() + "')", con);
                cmd.ExecuteNonQuery();

                con.Close();
                Clear();
                DisplayDataGridView();
                DisplaySaldo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            
            Clear();
            DisplayDataGridView();
        }
        private void Clear()
        {
            tbNominal.Text = "";
            cmbTipe.Items.Clear();
            tbKeterangan.Text = "";
        }
        private void DisplayDataGridView()
        {
            try
            {
                tabel = new DataTable();
                con.Open();
                adapter = new SqlDataAdapter("SELECT * FROM Transaksi", con);
                adapter.Fill(tabel);
                dgvSejarahTransaksi.DataSource = tabel;
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        private void DisplaySaldo()
        {
            try
            {
                con.Open();
                DataTable totalPemasukan = new DataTable();
                DataTable totalPengeluaran = new DataTable();

                adapter = new SqlDataAdapter("SELECT SUM(Nominal) FROM Transaksi WHERE Tipe = 'Pemasukan'", con);
                adapter.Fill(totalPemasukan);
                lblNilaiTotalPemasukan.Text = totalPemasukan.Rows[0][0].ToString();

                adapter = new SqlDataAdapter("SELECT SUM(Nominal) FROM Transaksi WHERE Tipe = 'Pengeluaran'", con);
                adapter.Fill(totalPengeluaran);
                lblNilaiTotalPengeluaran.Text = totalPengeluaran.Rows[0][0].ToString();

                lblNilaiSaldo.Text = (int.Parse(lblNilaiTotalPemasukan.Text) - int.Parse(lblNilaiTotalPengeluaran.Text)).ToString();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
