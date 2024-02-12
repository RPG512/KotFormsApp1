using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KotFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            Random random = new Random();
            double balanse = 0;
            double[] doubles = new double[5];
            TextBox[] names = new TextBox[5] { textBoxCostPrice, textBoxPrice, textBoxCosts, textBoxCount, textBoxPercent };
            bool conv = false;
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].Text == "")
                {
                    conv = false;
                    break;
                }
                else
                    conv = true;
            }
            if (conv)
            {
                for (int i = 0; i < names.Length; i++)
                    doubles[i] = Convert.ToDouble(names[i].Text);
                while (doubles[3] > 0)
                {
                    if (random.Next(101) > doubles[4])
                    {
                        balanse += doubles[1] - doubles[0] - doubles[2];
                        doubles[3]--;
                    }
                    else
                        balanse -= doubles[2];
                    chart1.Series[0].Points.Add(balanse);
                }
            }
            else
                MessageBox.Show("Пожалуйста введите все значения!");
            
        }
    }
}
