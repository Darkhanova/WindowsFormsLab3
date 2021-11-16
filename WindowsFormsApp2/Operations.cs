using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Drob
    {
        private int _znam, _chisl;
        private String str;

        public int znam { get => _znam; }
        public int chisl { get => _chisl; }
        public String getStr { get => str; }

        public Drob(int ch, int z)
        {
            _znam = z;
            _chisl = ch;
        }

        public Drob(String text)
        {
            str = text;
        }

        public String output()
        {
            return _chisl + "/" + _znam;
        }

        public static Drob operator +(Drob drob1, Drob drob2)
        {
            return new Drob(drob1.chisl * drob2.znam + drob1.znam * drob2.chisl, drob1.znam * drob2.znam);
        }
        public static Drob operator -(Drob drob1, Drob drob2)
        {
            return new Drob(drob1.chisl * drob2.znam - drob2.chisl * drob1.znam, drob1.znam * drob2.znam);
        }
        public static Drob operator *(Drob drob1, Drob drob2)
        {
            return new Drob(drob1.chisl * drob2.chisl, drob1.znam * drob2.znam); ;
        }
        public static Drob operator /(Drob drob1, Drob drob2)
        {
            return new Drob(drob1.chisl * drob2.znam, drob1.znam * drob2.chisl);
        }
        public static Drob operator %(Drob drob1, Drob drob2)
        {
            
            for(int i = 2; i <= drob1.znam; i++)
            {
                if(drob1.znam % i == 0 && drob1.chisl % i == 0)
                {
                    drob1._znam = drob1.znam / i;
                    drob1._chisl = drob1.chisl / i;
                }
            }
            return new Drob(drob1._chisl, drob1._znam);
        }

        public static Drob operator ^(Drob drob1, Drob drob2)
        {
            if ((double)drob1.chisl / (double)drob1.znam == (double)drob2.chisl / (double)drob2.znam)
                return new Drob("Равны");
            else
                return new Drob("Не равны");
        }
    }
}
