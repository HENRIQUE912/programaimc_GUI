
namespace IMC_GRAFICO
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nome = new System.Windows.Forms.TextBox();
            this.peso1 = new System.Windows.Forms.TextBox();
            this.altura = new System.Windows.Forms.TextBox();
            this.imc_atual = new System.Windows.Forms.TextBox();
            this.calcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2sexo = new System.Windows.Forms.Label();
            this.peso = new System.Windows.Forms.Label();
            this.label4altura = new System.Windows.Forms.Label();
            this.IMC = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.textBox1status = new System.Windows.Forms.TextBox();
            this.imc_ideal = new System.Windows.Forms.Label();
            this.imc_idael = new System.Windows.Forms.TextBox();
            this.masculino = new System.Windows.Forms.RadioButton();
            this.feminino = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.paciente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.relatorio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(79, 19);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(100, 23);
            this.nome.TabIndex = 0;
            // 
            // peso1
            // 
            this.peso1.Location = new System.Drawing.Point(79, 61);
            this.peso1.Name = "peso1";
            this.peso1.Size = new System.Drawing.Size(100, 23);
            this.peso1.TabIndex = 2;
            // 
            // altura
            // 
            this.altura.Location = new System.Drawing.Point(79, 95);
            this.altura.Name = "altura";
            this.altura.Size = new System.Drawing.Size(100, 23);
            this.altura.TabIndex = 3;
            // 
            // imc_atual
            // 
            this.imc_atual.Location = new System.Drawing.Point(79, 313);
            this.imc_atual.Name = "imc_atual";
            this.imc_atual.Size = new System.Drawing.Size(100, 23);
            this.imc_atual.TabIndex = 4;
            // 
            // calcular
            // 
            this.calcular.BackColor = System.Drawing.Color.Lime;
            this.calcular.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.calcular.Location = new System.Drawing.Point(42, 224);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(130, 40);
            this.calcular.TabIndex = 5;
            this.calcular.Text = "CALCULAR";
            this.calcular.UseVisualStyleBackColor = false;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "NOME";
            // 
            // label2sexo
            // 
            this.label2sexo.AutoSize = true;
            this.label2sexo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2sexo.Location = new System.Drawing.Point(25, 138);
            this.label2sexo.Name = "label2sexo";
            this.label2sexo.Size = new System.Drawing.Size(35, 15);
            this.label2sexo.TabIndex = 7;
            this.label2sexo.Text = "SEXO";
            // 
            // peso
            // 
            this.peso.AutoSize = true;
            this.peso.Location = new System.Drawing.Point(22, 61);
            this.peso.Name = "peso";
            this.peso.Size = new System.Drawing.Size(35, 15);
            this.peso.TabIndex = 8;
            this.peso.Text = "PESO";
            // 
            // label4altura
            // 
            this.label4altura.AutoSize = true;
            this.label4altura.Location = new System.Drawing.Point(22, 98);
            this.label4altura.Name = "label4altura";
            this.label4altura.Size = new System.Drawing.Size(49, 15);
            this.label4altura.TabIndex = 9;
            this.label4altura.Text = "ALTURA";
            // 
            // IMC
            // 
            this.IMC.AutoSize = true;
            this.IMC.Location = new System.Drawing.Point(12, 321);
            this.IMC.Name = "IMC";
            this.IMC.Size = new System.Drawing.Size(29, 15);
            this.IMC.TabIndex = 10;
            this.IMC.Text = "IMC";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(10, 350);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(45, 15);
            this.status.TabIndex = 11;
            this.status.Text = "STATUS";
            // 
            // textBox1status
            // 
            this.textBox1status.Location = new System.Drawing.Point(79, 342);
            this.textBox1status.Name = "textBox1status";
            this.textBox1status.Size = new System.Drawing.Size(100, 23);
            this.textBox1status.TabIndex = 12;
            // 
            // imc_ideal
            // 
            this.imc_ideal.AutoSize = true;
            this.imc_ideal.Location = new System.Drawing.Point(10, 379);
            this.imc_ideal.Name = "imc_ideal";
            this.imc_ideal.Size = new System.Drawing.Size(63, 15);
            this.imc_ideal.TabIndex = 13;
            this.imc_ideal.Text = "IMC IDEAL";
            // 
            // imc_idael
            // 
            this.imc_idael.Location = new System.Drawing.Point(79, 371);
            this.imc_idael.Name = "imc_idael";
            this.imc_idael.Size = new System.Drawing.Size(100, 23);
            this.imc_idael.TabIndex = 14;
            this.imc_idael.TextChanged += new System.EventHandler(this.imc_idael_TextChanged);
            // 
            // masculino
            // 
            this.masculino.AutoSize = true;
            this.masculino.Location = new System.Drawing.Point(79, 138);
            this.masculino.Name = "masculino";
            this.masculino.Size = new System.Drawing.Size(93, 19);
            this.masculino.TabIndex = 15;
            this.masculino.TabStop = true;
            this.masculino.Text = "MASCULINO";
            this.masculino.UseVisualStyleBackColor = true;
            // 
            // feminino
            // 
            this.feminino.AutoSize = true;
            this.feminino.Location = new System.Drawing.Point(189, 138);
            this.feminino.Name = "feminino";
            this.feminino.Size = new System.Drawing.Size(81, 19);
            this.feminino.TabIndex = 16;
            this.feminino.TabStop = true;
            this.feminino.Text = "FEMININO";
            this.feminino.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(22, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "RESULTADOS ATUAL";
            // 
            // paciente
            // 
            this.paciente.BackColor = System.Drawing.SystemColors.HotTrack;
            this.paciente.Location = new System.Drawing.Point(79, 284);
            this.paciente.Name = "paciente";
            this.paciente.Size = new System.Drawing.Size(100, 23);
            this.paciente.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "PACIENTE";
            // 
            // relatorio
            // 
            this.relatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.relatorio.Location = new System.Drawing.Point(260, 313);
            this.relatorio.Name = "relatorio";
            this.relatorio.Size = new System.Drawing.Size(85, 76);
            this.relatorio.TabIndex = 25;
            this.relatorio.Text = "relatorio";
            this.relatorio.UseVisualStyleBackColor = false;
            this.relatorio.Click += new System.EventHandler(this.relatorio_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(406, 413);
            this.ControlBox = false;
            this.Controls.Add(this.relatorio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.paciente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.feminino);
            this.Controls.Add(this.masculino);
            this.Controls.Add(this.imc_idael);
            this.Controls.Add(this.imc_ideal);
            this.Controls.Add(this.textBox1status);
            this.Controls.Add(this.status);
            this.Controls.Add(this.IMC);
            this.Controls.Add(this.label4altura);
            this.Controls.Add(this.peso);
            this.Controls.Add(this.label2sexo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.imc_atual);
            this.Controls.Add(this.altura);
            this.Controls.Add(this.peso1);
            this.Controls.Add(this.nome);
            this.Name = "Form1";
            this.Text = "Calculadora de IMC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.TextBox peso1;
        private System.Windows.Forms.TextBox altura;
        private System.Windows.Forms.TextBox imc_atual;
        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2sexo;
        private System.Windows.Forms.Label peso;
        private System.Windows.Forms.Label label4altura;
        private System.Windows.Forms.Label IMC;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.TextBox textBox1status;
        private System.Windows.Forms.Label imc_ideal;
        private System.Windows.Forms.TextBox imc_idael;
        private System.Windows.Forms.RadioButton masculino;
        private System.Windows.Forms.RadioButton feminino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox paciente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button relatorio;
    }
}

