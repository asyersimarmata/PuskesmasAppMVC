using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuskesmasAppMVC.Model.Entity
{
    public class Resep
    {
        public string kd_resep { get; set; }
        public DateTime tanggal { get; set; }
        public Pasien Pasien { get; set; }
        public Penyakit Penyakit { get; set; }
        public Obat Obat { get; set; }
    }
}
