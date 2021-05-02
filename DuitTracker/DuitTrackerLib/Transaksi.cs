using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuitTrackerLib
{
    public class Transaksi
    {
        int Nominal { get; set; }
        string Tipe { get; set; }
        string Keterangan { get; set; }
        DateTime Tanggal { get; set; }

        public Transaksi(int nominal, string tipe, string keterangan, DateTime tanggal)
        {
            this.Nominal = nominal;
            this.Tipe = tipe;
            this.Keterangan = keterangan;
            this.Tanggal = tanggal;
        }
    }
}
