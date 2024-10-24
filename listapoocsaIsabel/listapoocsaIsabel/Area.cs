using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listapoocsaIsabel
{
    internal class Area
    {
        private int a;
        private int b;
        private int area;

        public void setaltura(int a)
        {
            this.a = a;
        }

        public void setbase(int b)
        {
            this.b = b;
        }

        public int getaltura()
        {
            return this.a;
        }

        public int getbase()
        {
            return this.b;
        }

        public int getarea()
        {
            return this.area;
        }

        public void calcularArea()
        {
            this.area = this.b * this.a;
        }
    }
}
