namespace Execicios_Array
{
    partial class frm_exec2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_exec2));
            this.lb_enunciado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.insert_values2 = new System.Windows.Forms.TextBox();
            this.bt_gerar2 = new System.Windows.Forms.Button();
            this.bt_gerar = new System.Windows.Forms.Button();
            this.insert_values = new System.Windows.Forms.TextBox();
            this.lb_isert_points = new System.Windows.Forms.Label();
            this.lb_pt_geardo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_enunciado
            // 
            this.lb_enunciado.AutoSize = true;
            this.lb_enunciado.Location = new System.Drawing.Point(45, 20);
            this.lb_enunciado.Name = "lb_enunciado";
            this.lb_enunciado.Size = new System.Drawing.Size(701, 160);
            this.lb_enunciado.TabIndex = 0;
            this.lb_enunciado.Text = resources.GetString("lb_enunciado.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 462);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = " ";
            // 
            // insert_values2
            // 
            this.insert_values2.Location = new System.Drawing.Point(266, 366);
            this.insert_values2.Name = "insert_values2";
            this.insert_values2.Size = new System.Drawing.Size(269, 27);
            this.insert_values2.TabIndex = 2;
            // 
            // bt_gerar2
            // 
            this.bt_gerar2.Location = new System.Drawing.Point(358, 412);
            this.bt_gerar2.Name = "bt_gerar2";
            this.bt_gerar2.Size = new System.Drawing.Size(94, 29);
            this.bt_gerar2.TabIndex = 3;
            this.bt_gerar2.Text = "Gerar";
            this.bt_gerar2.UseVisualStyleBackColor = true;
            this.bt_gerar2.Click += new System.EventHandler(this.bt_gerar_Click);
            // 
            // bt_gerar
            // 
            this.bt_gerar.Location = new System.Drawing.Point(358, 291);
            this.bt_gerar.Name = "bt_gerar";
            this.bt_gerar.Size = new System.Drawing.Size(94, 29);
            this.bt_gerar.TabIndex = 5;
            this.bt_gerar.Text = "Gerar";
            this.bt_gerar.UseVisualStyleBackColor = true;
            this.bt_gerar.Click += new System.EventHandler(this.button1_Click);
            // 
            // insert_values
            // 
            this.insert_values.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.insert_values.Location = new System.Drawing.Point(374, 233);
            this.insert_values.MaxLength = 2;
            this.insert_values.Name = "insert_values";
            this.insert_values.Size = new System.Drawing.Size(61, 52);
            this.insert_values.TabIndex = 4;
            // 
            // lb_isert_points
            // 
            this.lb_isert_points.AutoSize = true;
            this.lb_isert_points.Location = new System.Drawing.Point(279, 210);
            this.lb_isert_points.Name = "lb_isert_points";
            this.lb_isert_points.Size = new System.Drawing.Size(245, 20);
            this.lb_isert_points.TabIndex = 6;
            this.lb_isert_points.Text = "Quantas potuações serão inseridas?";
            // 
            // lb_pt_geardo
            // 
            this.lb_pt_geardo.AutoSize = true;
            this.lb_pt_geardo.Location = new System.Drawing.Point(279, 343);
            this.lb_pt_geardo.Name = "lb_pt_geardo";
            this.lb_pt_geardo.Size = new System.Drawing.Size(236, 20);
            this.lb_pt_geardo.TabIndex = 7;
            this.lb_pt_geardo.Text = "Quais pontuações serão inseridas?";
            // 
            // frm_exec2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 515);
            this.Controls.Add(this.lb_pt_geardo);
            this.Controls.Add(this.lb_isert_points);
            this.Controls.Add(this.bt_gerar);
            this.Controls.Add(this.insert_values);
            this.Controls.Add(this.bt_gerar2);
            this.Controls.Add(this.insert_values2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_enunciado);
            this.Name = "frm_exec2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_exec2";
            this.Load += new System.EventHandler(this.frm_exec2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lb_enunciado;
        private Label label2;
        private TextBox insert_values2;
        private Button bt_gerar2;
        private Button bt_gerar;
        private TextBox insert_values;
        private Label lb_isert_points;
        private Label lb_pt_geardo;
    }
}