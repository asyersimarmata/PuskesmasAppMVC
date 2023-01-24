using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuskesmasAppMVC.Model.Entity
{
    public class JadwalDokter
    {
        public string kd_jadwal { get; set; }
        public string hari { get; set; }
        public string shift { get; set; }
        public Dokter Dokter { get; set; }
    }
}
