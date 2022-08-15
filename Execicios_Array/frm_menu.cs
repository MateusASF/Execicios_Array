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
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
        }

        private void bt_exec1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_exec1 frm = new frm_exec1();
            frm.ShowDialog();
            this.Show();
        }

        private void bt_exec2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_exec2 frm = new frm_exec2();
            frm.ShowDialog();
            this.Show();
        }

        private void bt_exec3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_exec3 frm = new frm_exec3();
            frm.ShowDialog();
            this.Show();
        }

        private void bt_exec4_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_exec4 frm = new frm_exec4();
            frm.ShowDialog();
            this.Show();
        }
    }
}
