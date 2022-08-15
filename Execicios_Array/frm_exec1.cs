using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Execicios_Array
{
    public partial class frm_exec1 : Form
    {
        public frm_exec1()
        {
            InitializeComponent();
        }


        private void bt_resultado_Click_1(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;

            int[] array = new int[10];

            for (int i = 0; i < 10; i++)
            {
                array[i] = Convert.ToInt32(textBox1.Text.Replace(",", "").Split(' ')[i]);
            }

            Array.Sort(array);

            arrumar(array);


        }

        private void frm_exec1_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
        }

        private void arrumar(int[] s)
        {
            for (int i = 0; i < 10; i++)
            {
                label1.Text += s[i].ToString() + ", ";

                if (s[i] % 2 == 0)
                {
                    label2.Text += s[i].ToString() + ", ";
                }

                if (s[i] % 2 != 0)
                {
                    label3.Text += s[i].ToString() + ", ";
                }
            }
        }
    }
}
