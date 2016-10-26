using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoiTien
{
    class Import
    {
        public double menhGia;
        public int soLuong;


        public void mg(double p)
        {
            this.menhGia = p;
        }

        public void sl(int p)
        {
            this.soLuong = p;
        }

        public double mg()
        {
            return this.menhGia;
        }

        public double sl()
        {
            return this.soLuong;
        }
    }
}
