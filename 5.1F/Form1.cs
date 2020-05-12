using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5._1F
{
    public partial class s : Form
    {
        public s()
        {
            InitializeComponent();
        }
        private double f(double x)
        {
            try
            {
                if (x <= -1 || x <= 1) throw new Exception();
                else return Math.Log(x * x * x * x - 1) * Math.Log(1 + x);
            }
            catch
            {
                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                V.Text = "";
                double a = double.Parse(A.Text);
                double b = double.Parse(B.Text);
                double h = double.Parse(H.Text);
                
                for (double i = a; i <= b; i += h)
                    try
                    {
                        V.Text +=Environment.NewLine ;
                       V.Text += "y(" + i + ")=" + f(i);
                    }
                    catch
                    {
                        V.Text += "y(" + i + ")=error";
                    }
            }
            catch (FormatException)
            {
                V.Text += "Неверный формат ввода данных";
            }
            catch
            {
                V.Text += "Неизвестная ошибка";
            }

        }
    }
}
