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
    public partial class frm_exec2 : Form
    {
        public int rank = 1;
        public int value = 0;
        public int indice = 0;


        public frm_exec2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            value = Convert.ToInt32(insert_values.Text);
            bt_gerar2.Visible = true;
            insert_values2.Visible = true;
            lb_pt_geardo.Visible = true;
        }

        private void bt_gerar_Click(object sender, EventArgs e)
        {
            int[] array = new int[value];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(insert_values2.Text.Replace(",", "").Split(' ')[i]);
            }
            arrumar(array);
        }

        public void arrumar(int[] x)
        {
            int[] copy = new int[x.Length];
            int[] retorno = new int[x.Length];

            for (int i = 0; i < x.Length; i++)
            {
                copy[i] = x[i];
            }

            Array.Sort(copy);
            Array.Reverse(copy);

            for (int i = 0; i < x.Length; i++)
            {
                foreach (var obj in x)
                {
                    if (x[i] == obj)
                    {
                        retorno[i] = Array.IndexOf(copy, x[i]) + 1;
                    }
                }

                #region
                //if (i == 0 || x[i] == x[i - 1])
                //{
                //    copy[i] = rank;
                //    label2.Text += copy[i].ToString();
                //}
                //else
                //{
                //    rank++;
                //    copy[i] = rank;
                //    label2.Text += copy[i].ToString();
                //}
                #endregion
            }

            foreach (var felizEstou in retorno)
            {
                label2.Text += felizEstou;
            }
        }
        private void frm_exec2_Load(object sender, EventArgs e)
        {
            bt_gerar2.Visible = false;
            insert_values2.Visible = false;
            lb_pt_geardo.Visible = false;
        }
    }
}

