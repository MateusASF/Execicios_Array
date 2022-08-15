namespace Execicios_Array
{
    partial class frm_menu
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
            this.lb_titulo_menu = new System.Windows.Forms.Label();
            this.bt_exec1 = new System.Windows.Forms.Button();
            this.bt_exec2 = new System.Windows.Forms.Button();
            this.bt_exec3 = new System.Windows.Forms.Button();
            this.bt_exec4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_titulo_menu
            // 
            this.lb_titulo_menu.AutoSize = true;
            this.lb_titulo_menu.Location = new System.Drawing.Point(328, 41);
            this.lb_titulo_menu.Name = "lb_titulo_menu";
            this.lb_titulo_menu.Size = new System.Drawing.Size(162, 20);
            this.lb_titulo_menu.TabIndex = 0;
            this.lb_titulo_menu.Text = "Exercicios Sobre Arrays";
            // 
            // bt_exec1
            // 
            this.bt_exec1.Location = new System.Drawing.Point(180, 134);
            this.bt_exec1.Name = "bt_exec1";
            this.bt_exec1.Size = new System.Drawing.Size(170, 116);
            this.bt_exec1.TabIndex = 1;
            this.bt_exec1.Text = "Exercício 1";
            this.bt_exec1.UseVisualStyleBackColor = true;
            this.bt_exec1.Click += new System.EventHandler(this.bt_exec1_Click);
            // 
            // bt_exec2
            // 
            this.bt_exec2.Location = new System.Drawing.Point(460, 134);
            this.bt_exec2.Name = "bt_exec2";
            this.bt_exec2.Size = new System.Drawing.Size(170, 116);
            this.bt_exec2.TabIndex = 2;
            this.bt_exec2.Text = "Exercício 2";
            this.bt_exec2.UseVisualStyleBackColor = true;
            this.bt_exec2.Click += new System.EventHandler(this.bt_exec2_Click);
            // 
            // bt_exec3
            // 
            this.bt_exec3.Location = new System.Drawing.Point(180, 305);
            this.bt_exec3.Name = "bt_exec3";
            this.bt_exec3.Size = new System.Drawing.Size(170, 116);
            this.bt_exec3.TabIndex = 3;
            this.bt_exec3.Text = "Exercício 3";
            this.bt_exec3.UseVisualStyleBackColor = true;
            this.bt_exec3.Click += new System.EventHandler(this.bt_exec3_Click);
            // 
            // bt_exec4
            // 
            this.bt_exec4.Location = new System.Drawing.Point(460, 305);
            this.bt_exec4.Name = "bt_exec4";
            this.bt_exec4.Size = new System.Drawing.Size(170, 116);
            this.bt_exec4.TabIndex = 4;
            this.bt_exec4.Text = "Exercício 4";
            this.bt_exec4.UseVisualStyleBackColor = true;
            this.bt_exec4.Click += new System.EventHandler(this.bt_exec4_Click);
            // 
            // frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_exec4);
            this.Controls.Add(this.bt_exec3);
            this.Controls.Add(this.bt_exec2);
            this.Controls.Add(this.bt_exec1);
            this.Controls.Add(this.lb_titulo_menu);
            this.Name = "frm_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lb_titulo_menu;
        private Button bt_exec1;
        private Button bt_exec2;
        private Button bt_exec3;
        private Button bt_exec4;
    }
}