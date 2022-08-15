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
    public partial class frm_exec3 : Form
    {
        public frm_exec3()
        {
            InitializeComponent();
        }

        int set = 1;

        private void bt_gerarMatriz_Click(object sender, EventArgs e)
        {

            ltb_result.Items.Clear();

            int x, y;

            x = Convert.ToInt32(mk_insert_linha.Text);
            y = Convert.ToInt32(mk_insert_coluna.Text);

            string[,] matriz = new string[x,y];

            lb_text_matriz.Text = $"Matriz Gerada no tamanho {x} linha(s) por {y} coluna(s)"; 
                    
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                string linha = "";

                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    linha += "  " + set++;
                    
                }
                
                ltb_result.Items.Add(linha);
            }

        }
    }
}
