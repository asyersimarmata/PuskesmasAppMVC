using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuskesmasAppMVC.Model.Entity
{
    public class Pasien
    {
        public string kd_pasien { get; set; }
        public string nama { get; set; }
        public DateTime tgl_lahir { get; set; }
        public string alamat { get; set; }

    }
}
