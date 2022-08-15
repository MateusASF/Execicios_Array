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
    public partial class frm_exec4 : Form
    {
        string player = "";
        bool jogador = false;
        string[,] matriz = new string[3, 3];
        public frm_exec4()
        {
            InitializeComponent();
        }

        private void frm_exec4_Load(object sender, EventArgs e)
        {
            button1.Click += new EventHandler(Bart);
            button2.Click += new EventHandler(Bart);
            button3.Click += new EventHandler(Bart);
            button4.Click += new EventHandler(Bart);
            button5.Click += new EventHandler(Bart);
            button6.Click += new EventHandler(Bart);
            button7.Click += new EventHandler(Bart);
            button8.Click += new EventHandler(Bart);
            button9.Click += new EventHandler(Bart);


            foreach (Control item in this.Controls)
            {
                if (item is Button)
                {
                    item.TabStop = false;
                }
            }
        }

        private void Bart(object sender, EventArgs e)
        {
            player = ((Button)sender).Text = this.jogador ? "X" : "O";
            ((Button)sender).Text = player;
            ((Button)sender).Enabled = false;

            #region
            if (button1.Text != "")
            {
                if (button1.Text != "X")
                {
                    matriz[0, 0] = "O";
                }
                else
                {
                    matriz[0, 0] = "X";
                }

            }

            if (button2.Text != "")
            {
                if (button2.Text != "X")
                {
                    matriz[0, 1] = "O";
                }
                else
                {
                    matriz[0, 1] = "X";
                }
            }

            if (button3.Text != "")
            {
                if (button3.Text != "X")
                {
                    matriz[0, 2] = "O";
                }
                else
                {
                    matriz[0, 2] = "X";
                }
            }

            if (button4.Text != "")
            {
                if (button4.Text != "X")
                {
                    matriz[1, 0] = "O";
                }
                else
                {
                    matriz[1, 0] = "X";
                }
            }

            if (button5.Text != "")
            {
                if (button5.Text != "X")
                {
                    matriz[1, 1] = "O";
                }
                else
                {
                    matriz[1, 1] = "X";
                }
            }

            if (button6.Text != "")
            {
                if (button6.Text != "X")
                {
                    matriz[1, 2] = "O";
                }
                else
                {
                    matriz[1, 2] = "X";
                }
            }

            if (button7.Text != "")
            {
                if (button7.Text != "X")
                {
                    matriz[2, 0] = "O";
                }
                else
                {
                    matriz[2, 0] = "X";
                }
            }

            if (button8.Text != "")
            {
                if (button8.Text != "X")
                {
                    matriz[2, 1] = "O";
                }
                else
                {
                    matriz[2, 1] = "X";
                }
            }

            if (button9.Text != "")
            {
                if (button9.Text != "X")
                {
                    matriz[2, 2] = "O";
                }
                else
                {
                    matriz[2, 2] = "X";
                }
            }
            #endregion

            jogador = !jogador;

            ganhador();
        }



        private void ganhador()
        {

            if (
            #region
            matriz[0, 0] != null && matriz[0, 0] == matriz[0, 1] && matriz[0, 0] == matriz[0, 2] ||
            matriz[1, 0] != null && matriz[1, 0] == matriz[1, 1] && matriz[1, 0] == matriz[1, 2] ||
            matriz[2, 0] != null && matriz[2, 0] == matriz[2, 1] && matriz[2, 0] == matriz[2, 2] ||

            matriz[0, 0] != null && matriz[0, 0] == matriz[1, 0] && matriz[0, 0] == matriz[2, 0] ||
            matriz[0, 1] != null && matriz[0, 1] == matriz[1, 1] && matriz[0, 1] == matriz[2, 1] ||
            matriz[0, 2] != null && matriz[0, 2] == matriz[1, 2] && matriz[0, 2] == matriz[2, 2] ||

            matriz[0, 0] != null && matriz[0, 0] == matriz[1, 1] && matriz[0, 0] == matriz[2, 2] ||
            matriz[2, 0] != null && matriz[2, 0] == matriz[1, 1] && matriz[2, 0] == matriz[0, 2])
            #endregion
            {
                MessageBox.Show(String.Format("O ganhador é o {0}", player), "Temos um vitorioso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                reiniciar();
            }
            else
            {
                empate();
            }
        }

        private void reiniciar()
        {
            foreach (Control item in this.Controls)
            {
                if (item is Button)
                {
                    item.Enabled = true;
                    item.Text = String.Empty;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matriz[i, j] = null;
                }
            }
        }

        private void empate()
        {

            bool todosDesabilitados = true;
            foreach (Control item in this.Controls)
            {
                if (item is Button && item.Enabled)
                {
                    todosDesabilitados = false;
                    break;
                }

            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matriz[i, j] = null;
                }
            }

            if (todosDesabilitados)
            {
                MessageBox.Show(String.Format("Deu empate"), "Ops !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                reiniciar();
            }
        }


    }
}
