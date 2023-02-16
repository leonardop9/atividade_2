
namespace atividade_01
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.listB_Nota_1 = new System.Windows.Forms.ListBox();
            this.listB_Nome = new System.Windows.Forms.ListBox();
            this.listB_Nota_2 = new System.Windows.Forms.ListBox();
            this.listB_Nota_3 = new System.Windows.Forms.ListBox();
            this.listB_Nota_4 = new System.Windows.Forms.ListBox();
            this.lbl_Media = new System.Windows.Forms.Label();
            this.listB_Nota_5 = new System.Windows.Forms.ListBox();
            this.listB_Nota_6 = new System.Windows.Forms.ListBox();
            this.listB_Nota_7 = new System.Windows.Forms.ListBox();
            this.listB_Nota_8 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_result = new System.Windows.Forms.Label();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.txt_resultado = new System.Windows.Forms.TextBox();
            this.txt_limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(429, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "MÉDIA DOS ALUNOS";
            // 
            // listB_Nota_1
            // 
            this.listB_Nota_1.FormattingEnabled = true;
            this.listB_Nota_1.Location = new System.Drawing.Point(238, 122);
            this.listB_Nota_1.Name = "listB_Nota_1";
            this.listB_Nota_1.Size = new System.Drawing.Size(102, 329);
            this.listB_Nota_1.TabIndex = 2;
            this.listB_Nota_1.SelectedIndexChanged += new System.EventHandler(this.listB_Nota_1_SelectedIndexChanged);
            // 
            // listB_Nome
            // 
            this.listB_Nome.FormattingEnabled = true;
            this.listB_Nome.Location = new System.Drawing.Point(130, 122);
            this.listB_Nome.Name = "listB_Nome";
            this.listB_Nome.Size = new System.Drawing.Size(102, 329);
            this.listB_Nome.TabIndex = 3;
            this.listB_Nome.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // listB_Nota_2
            // 
            this.listB_Nota_2.FormattingEnabled = true;
            this.listB_Nota_2.Location = new System.Drawing.Point(346, 122);
            this.listB_Nota_2.Name = "listB_Nota_2";
            this.listB_Nota_2.Size = new System.Drawing.Size(102, 329);
            this.listB_Nota_2.TabIndex = 4;
            this.listB_Nota_2.SelectedIndexChanged += new System.EventHandler(this.listB_Nota_2_SelectedIndexChanged);
            // 
            // listB_Nota_3
            // 
            this.listB_Nota_3.FormattingEnabled = true;
            this.listB_Nota_3.Location = new System.Drawing.Point(454, 122);
            this.listB_Nota_3.Name = "listB_Nota_3";
            this.listB_Nota_3.Size = new System.Drawing.Size(102, 329);
            this.listB_Nota_3.TabIndex = 5;
            this.listB_Nota_3.SelectedIndexChanged += new System.EventHandler(this.listB_Nota_3_SelectedIndexChanged);
            // 
            // listB_Nota_4
            // 
            this.listB_Nota_4.FormattingEnabled = true;
            this.listB_Nota_4.Location = new System.Drawing.Point(562, 122);
            this.listB_Nota_4.Name = "listB_Nota_4";
            this.listB_Nota_4.Size = new System.Drawing.Size(102, 329);
            this.listB_Nota_4.TabIndex = 6;
            this.listB_Nota_4.SelectedIndexChanged += new System.EventHandler(this.listB_Nota_4_SelectedIndexChanged);
            // 
            // lbl_Media
            // 
            this.lbl_Media.AutoSize = true;
            this.lbl_Media.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Media.Location = new System.Drawing.Point(354, 507);
            this.lbl_Media.Name = "lbl_Media";
            this.lbl_Media.Size = new System.Drawing.Size(90, 28);
            this.lbl_Media.TabIndex = 17;
            this.lbl_Media.Text = "Média:";
            this.lbl_Media.Click += new System.EventHandler(this.lbl_Media_Click);
            // 
            // listB_Nota_5
            // 
            this.listB_Nota_5.FormattingEnabled = true;
            this.listB_Nota_5.Location = new System.Drawing.Point(671, 122);
            this.listB_Nota_5.Name = "listB_Nota_5";
            this.listB_Nota_5.Size = new System.Drawing.Size(102, 329);
            this.listB_Nota_5.TabIndex = 19;
            this.listB_Nota_5.SelectedIndexChanged += new System.EventHandler(this.listB_Nota_5_SelectedIndexChanged);
            // 
            // listB_Nota_6
            // 
            this.listB_Nota_6.FormattingEnabled = true;
            this.listB_Nota_6.Location = new System.Drawing.Point(779, 122);
            this.listB_Nota_6.Name = "listB_Nota_6";
            this.listB_Nota_6.Size = new System.Drawing.Size(102, 329);
            this.listB_Nota_6.TabIndex = 20;
            this.listB_Nota_6.SelectedIndexChanged += new System.EventHandler(this.listB_Nota_6_SelectedIndexChanged);
            // 
            // listB_Nota_7
            // 
            this.listB_Nota_7.FormattingEnabled = true;
            this.listB_Nota_7.Location = new System.Drawing.Point(887, 122);
            this.listB_Nota_7.Name = "listB_Nota_7";
            this.listB_Nota_7.Size = new System.Drawing.Size(102, 329);
            this.listB_Nota_7.TabIndex = 21;
            this.listB_Nota_7.SelectedIndexChanged += new System.EventHandler(this.listB_Nota_7_SelectedIndexChanged);
            // 
            // listB_Nota_8
            // 
            this.listB_Nota_8.FormattingEnabled = true;
            this.listB_Nota_8.Location = new System.Drawing.Point(995, 122);
            this.listB_Nota_8.Name = "listB_Nota_8";
            this.listB_Nota_8.Size = new System.Drawing.Size(102, 329);
            this.listB_Nota_8.TabIndex = 22;
            this.listB_Nota_8.SelectedIndexChanged += new System.EventHandler(this.listB_Nota_8_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "Nome";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(235, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 18);
            this.label3.TabIndex = 24;
            this.label3.Text = "Português";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(343, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 18);
            this.label4.TabIndex = 25;
            this.label4.Text = "Matemática";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(454, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 18);
            this.label5.TabIndex = 26;
            this.label5.Text = "Geografia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(776, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 18);
            this.label6.TabIndex = 27;
            this.label6.Text = "Ciência";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(559, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 18);
            this.label7.TabIndex = 28;
            this.label7.Text = "História";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(668, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 18);
            this.label8.TabIndex = 29;
            this.label8.Text = "Inglês";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(884, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 18);
            this.label9.TabIndex = 30;
            this.label9.Text = "Ed Física";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(992, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 18);
            this.label10.TabIndex = 31;
            this.label10.Text = "Artes";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_result.Location = new System.Drawing.Point(450, 507);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(0, 28);
            this.lbl_result.TabIndex = 32;
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calcular.Location = new System.Drawing.Point(859, 483);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(143, 52);
            this.btn_Calcular.TabIndex = 33;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_resultado
            // 
            this.txt_resultado.Location = new System.Drawing.Point(457, 515);
            this.txt_resultado.Name = "txt_resultado";
            this.txt_resultado.Size = new System.Drawing.Size(124, 20);
            this.txt_resultado.TabIndex = 34;
            // 
            // txt_limpar
            // 
            this.txt_limpar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_limpar.Location = new System.Drawing.Point(1045, 483);
            this.txt_limpar.Name = "txt_limpar";
            this.txt_limpar.Size = new System.Drawing.Size(143, 52);
            this.txt_limpar.TabIndex = 35;
            this.txt_limpar.Text = "Limpar";
            this.txt_limpar.UseVisualStyleBackColor = true;
            this.txt_limpar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1200, 583);
            this.Controls.Add(this.txt_limpar);
            this.Controls.Add(this.txt_resultado);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listB_Nota_8);
            this.Controls.Add(this.listB_Nota_7);
            this.Controls.Add(this.listB_Nota_6);
            this.Controls.Add(this.listB_Nota_5);
            this.Controls.Add(this.lbl_Media);
            this.Controls.Add(this.listB_Nota_4);
            this.Controls.Add(this.listB_Nota_3);
            this.Controls.Add(this.listB_Nota_2);
            this.Controls.Add(this.listB_Nome);
            this.Controls.Add(this.listB_Nota_1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listB_Nota_1;
        private System.Windows.Forms.ListBox listB_Nome;
        private System.Windows.Forms.ListBox listB_Nota_2;
        private System.Windows.Forms.ListBox listB_Nota_3;
        private System.Windows.Forms.ListBox listB_Nota_4;
        private System.Windows.Forms.Label lbl_Media;
        private System.Windows.Forms.ListBox listB_Nota_5;
        private System.Windows.Forms.ListBox listB_Nota_6;
        private System.Windows.Forms.ListBox listB_Nota_7;
        private System.Windows.Forms.ListBox listB_Nota_8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.TextBox txt_resultado;
        private System.Windows.Forms.Button txt_limpar;
    }
}

