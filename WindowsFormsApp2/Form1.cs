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

        public int znamone;
        public int chislone;
        public int znamtwo;
        public int chisltwo;

        public Form1()
        {
            InitializeComponent();
        }

        public void inputdrob()
        {
            try
            {
                znamone = Convert.ToInt32(this.znam1.Text);
                chislone = Convert.ToInt32(this.chisl1.Text);
                znamtwo = Convert.ToInt32(this.znam2.Text);
                chisltwo = Convert.ToInt32(this.chisl2.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Заполните все поля");
            }
        }


        private void sum_Click(object sender, EventArgs e)
        {
            inputdrob();
            Drob drob1, drob2, drob3;
            if (chislone > znamone || chisltwo > znamtwo || znamone == 0 || znamtwo == 0 || chislone == znamone || chisltwo == znamtwo)
            {
                result.Text = "Ошибка! Дробь неправильная";
                return;
            }
            drob1 = new Drob(chislone, znamone);
            drob2 = new Drob(chisltwo, znamtwo);
            drob3 = drob1 + drob2;
            result.Text = drob3.output();
        }

        private void raz_Click(object sender, EventArgs e)
        {
            inputdrob();
            Drob drob1, drob2, drob3;
            if (chislone > znamone || chisltwo > znamtwo || znamone == 0 || znamtwo == 0 || chislone == znamone || chisltwo == znamtwo)
            {
                result.Text = "Ошибка! Дробь неправильная";
                return;
            }
            drob1 = new Drob(chislone, znamone);
            drob2 = new Drob(chisltwo, znamtwo);
            drob3 = drob1 - drob2;
            result.Text = drob3.output();
        }

        private void multi_Click(object sender, EventArgs e)
        {
            inputdrob();
            Drob drob1, drob2, drob3;
            if (chislone > znamone || chisltwo > znamtwo || znamone == 0 || znamtwo == 0 || chislone == znamone || chisltwo == znamtwo)
            {
                result.Text = "Ошибка! Дробь неправильная";
                return;
            }
            drob1 = new Drob(chislone, znamone);
            drob2 = new Drob(chisltwo, znamtwo);
            drob3 = drob1 * drob2;
            result.Text = drob3.output();
        }

        private void srav_Click(object sender, EventArgs e)
        {
            inputdrob();
            Drob drob1, drob2, drob3;
            if (chislone > znamone || chisltwo > znamtwo || znamone == 0 || znamtwo == 0 || chislone == znamone || chisltwo == znamtwo)
            {
                result.Text = "Ошибка! Дробь неправильная";
                return;
            }
            drob1 = new Drob(chislone, znamone);
            drob2 = new Drob(chisltwo, znamtwo);
            drob3 = drob1 ^ drob2;
            result.Text = drob3.getStr;
        }

        private void divide_Click(object sender, EventArgs e)
        {
            inputdrob();
            Drob drob1, drob2, drob3;
            if (chislone > znamone || chisltwo > znamtwo || znamone == 0 || znamtwo == 0 || chislone == znamone || chisltwo == znamtwo)
            {
                result.Text = "Ошибка! Дробь неправильная";
                return;
            }
            drob1 = new Drob(chislone, znamone);
            drob2 = new Drob(chisltwo, znamtwo);
            drob3 = drob1 / drob2;
            result.Text = drob3.output();
        }

        private void sokr_Click(object sender, EventArgs e)
        {
            znamone = Convert.ToInt32(this.znam1.Text);
            chislone = Convert.ToInt32(this.chisl1.Text);
            Drob drob1, drob2, drob3;
            if(result.Text.Length == 0)
            {
                if (chislone > znamone || znamone == 0 || chislone == znamone)
                {
                    result.Text = "Ошибка! Дробь неправильная";
                    return;
                }
                drob1 = new Drob(chislone, znamone);
                drob2 = new Drob(0, 0);
                drob3 = drob1 % drob2;
                result.Text = drob3.output();
            }
            else
            {
                String final = result.Text;
                String[] drobe = final.Split('/');
                int a = Convert.ToInt32(drobe[0]);
                int b = Convert.ToInt32(drobe[1]);
                drob1 = new Drob(a, b);
                drob2 = new Drob(0, 0);
                drob3 = drob1 % drob2;
                result.Text = drob3.output();
            }
        }
        
        
        private void Control_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }
        
        private void znam1_TextChanged_1(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(znam1.Text, "[^0-9]"))
            {
                MessageBox.Show("Пожалуйста, введите только числа");
                znam1.Text = znam1.Text.Remove(znam1.Text.Length - 1);
            }
        }

        private void chisl2_TextChanged_1(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(chisl2.Text, "[^0-9]"))
            {
                MessageBox.Show("Пожалуйста, введите только числа");
                chisl2.Text = chisl2.Text.Remove(chisl2.Text.Length - 1);
            }
        }

        private void znam2_TextChanged_1(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(znam2.Text, "[^0-9]"))
            {
                MessageBox.Show("Пожалуйста, введите только числа");
                znam2.Text = znam2.Text.Remove(znam2.Text.Length - 1);
            }
        }

        private void chisl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                znam1.Focus();
            }
        }

        private void znam1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                chisl2.Focus();
            }
        }

        private void chisl2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                znam2.Focus();
            }
        }

        private void znam2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                chisl1.Focus();
            }
        }

        private void chisl1_TextChanged_1(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(chisl1.Text, "[^0-9]"))
            {
                MessageBox.Show("Пожалуйста, введите только числа");
                chisl1.Text = chisl1.Text.Remove(chisl1.Text.Length - 1);
            }  
        }

        private void clear_Click(object sender, EventArgs e)
        {
            chisl1.Clear();
            chisl2.Clear();
            znam1.Clear();
            znam2.Clear();
            result.ResetText();
        }
    }
}

