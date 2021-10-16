using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
       



        public Form1()
        {
            InitializeComponent();
        }

        private void sum_Click(object sender, EventArgs e)
        {
            
            int znamone = Convert.ToInt32(this.znam1.Text);
            int znamtwo = Convert.ToInt32(this.znam2.Text);
            int chislone = Convert.ToInt32(this.chisl1.Text);
            int chisltwo = Convert.ToInt32(this.chisl2.Text);
            Drob drob1, drob2, drob3;
            if (chislone > znamone || chisltwo > znamtwo || znamone == 0 || znamtwo == 0)
            {
                result.Text = "Error";
                return;
            }
            drob1 = new Drob(chislone, znamone);
            drob2 = new Drob(chisltwo, znamtwo);
            drob3 = drob1 + drob2;
            result.Text = drob3.output();
        }

        private void raz_Click(object sender, EventArgs e)
        {
            int znamone = Convert.ToInt32(this.znam1.Text);
            int znamtwo = Convert.ToInt32(this.znam2.Text);
            int chislone = Convert.ToInt32(this.chisl1.Text);
            int chisltwo = Convert.ToInt32(this.chisl2.Text);
            Drob drob1, drob2, drob3;
            if (chislone > znamone || chisltwo > znamtwo || znamone == 0 || znamtwo == 0)
            {
                result.Text = "Error";
                return;
            }
            drob1 = new Drob(chislone, znamone);
            drob2 = new Drob(chisltwo, znamtwo);
            drob3 = drob1 - drob2;
            result.Text = drob3.output();
        }

        private void multi_Click(object sender, EventArgs e)
        {
            int znamone = Convert.ToInt32(this.znam1.Text);
            int znamtwo = Convert.ToInt32(this.znam2.Text);
            int chislone = Convert.ToInt32(this.chisl1.Text);
            int chisltwo = Convert.ToInt32(this.chisl2.Text);
            Drob drob1, drob2, drob3;
            if (chislone > znamone || chisltwo > znamtwo || znamone == 0 || znamtwo == 0)
            {
                result.Text = "Error";
                return;
            }
            drob1 = new Drob(chislone, znamone);
            drob2 = new Drob(chisltwo, znamtwo);
            drob3 = drob1 * drob2;
            result.Text = drob3.output();
        }

        private void srav_Click(object sender, EventArgs e)
        {
            int znamone = Convert.ToInt32(this.znam1.Text);
            int chislone = Convert.ToInt32(this.chisl1.Text);
            int znamtwo = Convert.ToInt32(this.znam2.Text);
            int chisltwo = Convert.ToInt32(this.chisl2.Text);
            Drob drob1, drob2, drob3;
            if (chislone > znamone || chisltwo > znamtwo || znamone == 0 || znamtwo == 0)
            {
                result.Text = "Error";
                return;
            }
            drob1 = new Drob(chislone, znamone);
            drob2 = new Drob(chisltwo, znamtwo);
            drob3 = drob1 ^ drob2;
            result.Text = drob3.getStr;
        }

        private void divide_Click(object sender, EventArgs e)
        {
            int znamone = Convert.ToInt32(this.znam1.Text);
            int znamtwo = Convert.ToInt32(this.znam2.Text);
            int chislone = Convert.ToInt32(this.chisl1.Text);
            int chisltwo = Convert.ToInt32(this.chisl2.Text);
            Drob drob1, drob2, drob3;
            if (chislone > znamone || chisltwo > znamtwo || znamone == 0 || znamtwo == 0)
            {
                result.Text = "Error";
                return;
            }
            drob1 = new Drob(chislone, znamone);
            drob2 = new Drob(chisltwo, znamtwo);
            drob3 = drob1 / drob2;
            result.Text = drob3.output();
        }

        private void sokr_Click(object sender, EventArgs e)
        {
            int znamone = Convert.ToInt32(this.znam1.Text);
            int chislone = Convert.ToInt32(this.chisl1.Text);
            Drob drob1, drob2, drob3;
            if (chislone > znamone || znamone == 0)
            {
                result.Text = "Error";
                return;
            }
            drob1 = new Drob(chislone, znamone);
            drob2 = new Drob(0, 0);
            drob3 = drob1 % drob2;
            result.Text = drob3.output();
        }
    }
}
