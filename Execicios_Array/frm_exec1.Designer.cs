namespace Execicios_Array
{
    partial class frm_exec1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_exec1));
            this.lb_enunciado = new System.Windows.Forms.Label();
            this.bt_resultado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_enunciado
            // 
            this.lb_enunciado.AutoSize = true;
            this.lb_enunciado.Location = new System.Drawing.Point(12, 9);
            this.lb_enunciado.Name = "lb_enunciado";
            this.lb_enunciado.Size = new System.Drawing.Size(764, 160);
            this.lb_enunciado.TabIndex = 0;
            this.lb_enunciado.Text = resources.GetString("lb_enunciado.Text");
            // 
            // bt_resultado
            // 
            this.bt_resultado.Location = new System.Drawing.Point(345, 316);
            this.bt_resultado.Name = "bt_resultado";
            this.bt_resultado.Size = new System.Drawing.Size(94, 29);
            this.bt_resultado.TabIndex = 2;
            this.bt_resultado.Text = "Ordenar";
            this.bt_resultado.UseVisualStyleBackColor = true;
            this.bt_resultado.Click += new System.EventHandler(this.bt_resultado_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Números Inseridos: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Números Pares: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 473);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Números Impares: ";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(223, 239);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(343, 41);
            this.textBox1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(343, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Insira 10 valores separando por espaços ou virgula";
            // 
            // frm_exec1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_resultado);
            this.Controls.Add(this.lb_enunciado);
            this.Name = "frm_exec1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_exec1";
            this.Load += new System.EventHandler(this.frm_exec1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lb_enunciado;
        private Button bt_resultado;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
    }
}