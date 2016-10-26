using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoiTien
{
    class User
    {
        public double soTien;
        public void tien(double t)
        {
            this.soTien = t;
        }
        public double tien()
        {
            return this.soTien;
        }
        public List<Import> Test(double n)
        {
            double temp = n;
            List<Import> ketQua = new List<Import>();
            if (temp > 0 && (temp / 100 != 0))
            {
                Import kq = new Import();
                kq.mg(100);
                kq.sl((int)temp / 100);
                ketQua.Add(kq);
                temp -= kq.mg() * kq.sl();

            }
            if (temp > 0 && (temp / 50 != 0))
            {
                Import kq = new Import();
                kq.mg(50);
                kq.sl((int)temp / 50);
                ketQua.Add(kq);
                temp -= kq.mg() * kq.sl();

            }
            if (temp > 0 && (temp / 20 != 0))
            {
                Import kq = new Import();
                kq.mg(20);
                kq.sl((int)temp / 20);
                ketQua.Add(kq);
                temp -= kq.mg() * kq.sl();

            }
            if (temp > 0 && (temp / 10 != 0))
            {
                Import kq = new Import();
                kq.mg(10);
                kq.sl((int)temp / 10);
                ketQua.Add(kq);
                temp -= kq.mg() * kq.sl();

            }
            return ketQua;
        }
    }
}
