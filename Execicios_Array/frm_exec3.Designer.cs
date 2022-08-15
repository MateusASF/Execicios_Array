namespace Execicios_Array
{
    partial class frm_exec3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lb_qntd_linhas = new System.Windows.Forms.Label();
            this.lb_qntd_colunas = new System.Windows.Forms.Label();
            this.mk_insert_linha = new System.Windows.Forms.MaskedTextBox();
            this.mk_insert_coluna = new System.Windows.Forms.MaskedTextBox();
            this.bt_gerarMatriz = new System.Windows.Forms.Button();
            this.ltb_result = new System.Windows.Forms.ListBox();
            this.lb_text_matriz = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(535, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enunciado\r\n\r\nPeça ao usuário uma quantidade de linhas e e outra de colunas, \r\ndep" +
    "ois declare tal matriz, inicialize todos os elementos de 1 até \'linha x coluna\'." +
    "";
            // 
            // lb_qntd_linhas
            // 
            this.lb_qntd_linhas.AutoSize = true;
            this.lb_qntd_linhas.Location = new System.Drawing.Point(163, 180);
            this.lb_qntd_linhas.Name = "lb_qntd_linhas";
            this.lb_qntd_linhas.Size = new System.Drawing.Size(208, 20);
            this.lb_qntd_linhas.TabIndex = 4;
            this.lb_qntd_linhas.Text = "Digite a quantidade de Linhas";
            // 
            // lb_qntd_colunas
            // 
            this.lb_qntd_colunas.AutoSize = true;
            this.lb_qntd_colunas.Location = new System.Drawing.Point(446, 180);
            this.lb_qntd_colunas.Name = "lb_qntd_colunas";
            this.lb_qntd_colunas.Size = new System.Drawing.Size(219, 20);
            this.lb_qntd_colunas.TabIndex = 5;
            this.lb_qntd_colunas.Text = "Digite a quantidade de Colunas\r\n";
            // 
            // mk_insert_linha
            // 
            this.mk_insert_linha.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mk_insert_linha.Location = new System.Drawing.Point(251, 125);
            this.mk_insert_linha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mk_insert_linha.Mask = "0";
            this.mk_insert_linha.Name = "mk_insert_linha";
            this.mk_insert_linha.Size = new System.Drawing.Size(37, 52);
            this.mk_insert_linha.TabIndex = 6;
            this.mk_insert_linha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mk_insert_coluna
            // 
            this.mk_insert_coluna.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mk_insert_coluna.Location = new System.Drawing.Point(537, 125);
            this.mk_insert_coluna.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mk_insert_coluna.Mask = "0";
            this.mk_insert_coluna.Name = "mk_insert_coluna";
            this.mk_insert_coluna.Size = new System.Drawing.Size(37, 52);
            this.mk_insert_coluna.TabIndex = 7;
            this.mk_insert_coluna.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bt_gerarMatriz
            // 
            this.bt_gerarMatriz.Location = new System.Drawing.Point(357, 224);
            this.bt_gerarMatriz.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_gerarMatriz.Name = "bt_gerarMatriz";
            this.bt_gerarMatriz.Size = new System.Drawing.Size(94, 29);
            this.bt_gerarMatriz.TabIndex = 8;
            this.bt_gerarMatriz.Text = "Gerar Matriz";
            this.bt_gerarMatriz.UseVisualStyleBackColor = true;
            this.bt_gerarMatriz.Click += new System.EventHandler(this.bt_gerarMatriz_Click);
            // 
            // ltb_result
            // 
            this.ltb_result.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ltb_result.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ltb_result.FormattingEnabled = true;
            this.ltb_result.ItemHeight = 23;
            this.ltb_result.Location = new System.Drawing.Point(300, 299);
            this.ltb_result.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ltb_result.MultiColumn = true;
            this.ltb_result.Name = "ltb_result";
            this.ltb_result.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ltb_result.Size = new System.Drawing.Size(200, 211);
            this.ltb_result.TabIndex = 9;
            // 
            // lb_text_matriz
            // 
            this.lb_text_matriz.AutoSize = true;
            this.lb_text_matriz.Location = new System.Drawing.Point(235, 279);
            this.lb_text_matriz.Name = "lb_text_matriz";
            this.lb_text_matriz.Size = new System.Drawing.Size(0, 20);
            this.lb_text_matriz.TabIndex = 10;
            this.lb_text_matriz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_exec3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 527);
            this.Controls.Add(this.lb_text_matriz);
            this.Controls.Add(this.ltb_result);
            this.Controls.Add(this.bt_gerarMatriz);
            this.Controls.Add(this.mk_insert_coluna);
            this.Controls.Add(this.mk_insert_linha);
            this.Controls.Add(this.lb_qntd_colunas);
            this.Controls.Add(this.lb_qntd_linhas);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_exec3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_exec3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lb_qntd_linhas;
        private Label lb_qntd_colunas;
        private MaskedTextBox mk_insert_linha;
        private MaskedTextBox mk_insert_coluna;
        private Button bt_gerarMatriz;
        private ListBox ltb_result;
        private Label lb_text_matriz;
    }
}