using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace IMC_GRAFICO
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void calcular_Click(object sender, EventArgs e)
        {
          
            double peso = double.Parse(peso1.Text);
            double alt = double.Parse(altura.Text);
            int i = 0;
           
            


            double imc = peso / (alt * alt);

           imc_atual.Text = imc.ToString();
            

            double peso_ideal = 23.55 * alt * alt;
            double  peso_final = 23.55 - peso_ideal;
            double imcfinal = peso_final * -1;
            double imc_ant = 0;

            paciente.Text = nome.Text;

            if (masculino.Checked)
            {
                if (imc < 20.6)
                {

                    imc_atual.Text = imc.ToString("f2");
                    textBox1status.Text = "ABAIXO DO PESO";
                    imc_idael.Text = imcfinal.ToString("f2");


                }

                if (imc > 20.7 & imc < 26.4)
                {
                    imc_atual.Text = imc.ToString("f2");
                    textBox1status.Text = "NO PESSO IDEAL";
                }

                if (imc > 26.4 & imc < 27.8)
                {
                    imc_atual.Text = imc.ToString("f2");
                    textBox1status.Text = "Marginalmente acima do peso";
                    imc_idael.Text = imcfinal.ToString("f2");
                }

                if (imc > 27.8 & imc < 31.1)
                {
                    imc_atual.Text = imc.ToString("f2");
                    textBox1status.Text = " acima do peso";
                    imc_idael.Text = imcfinal.ToString("f2");
                }
                if (imc > 31.1)
                {
                    imc_atual.Text = imc.ToString("f2");
                    textBox1status.Text = "OBESO";
                    imc_idael.Text = imcfinal.ToString("f2");

                }

            }

            if (feminino.Checked)
            {
               
                 

                    if (imc < 19.1)
                    {
                        imc_atual.Text = imc.ToString("f2");
                        textBox1status.Text = "ABAIXO DO PESO";
                        imc_idael.Text = imcfinal.ToString("f2");

                    }
                    if (imc > 19.1 & imc < 25.8)
                    {
                        imc_atual.Text = imc.ToString("f2");
                        textBox1status.Text = "NO PESSO IDEAL";
                    }
                    if (imc > 25.8 & imc < 27.3)
                    {
                        imc_atual.Text = imc.ToString("f2");
                        textBox1status.Text = "Marginalmente acima do peso";
                        imc_idael.Text = imcfinal.ToString("f2");
                    }
                    if (imc > 27.3 & imc < 32.3)
                    {
                        imc_atual.Text = imc.ToString("f2");
                        textBox1status.Text = " acima do peso";
                        imc_idael.Text = imcfinal.ToString("f2");
                    }
                    if (imc > 32.3)
                    {
                        imc_atual.Text = imc.ToString("f2");
                        textBox1status.Text = "OBESO";
                        imc_idael.Text = imcfinal.ToString("f2");
                    }
                
            }

          
        }

       

        private void imc_idael_TextChanged(object sender, EventArgs e)
        {

        }

        private void relatorio_Click(object sender, EventArgs e)
        {
            String path = @"C:\Users\Henrique\Documents\relatorio imc.txt";

            try
            {
                if (!File.Exists(path))
                {
                    
                      using (FileStream fs = File.Create(path))
                    {
                        fs.Close();
                    }

                    MessageBox.Show("Arquivo criado com sucesso");

                   

                }
                else
                {
                    double imcfinal = 0;
                    MessageBox.Show("RELAORIO CRIADO");
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.WriteLine("***********SUA DADOS DE EVOLUÇÃO***********");
                        sw.WriteLine(DateTime.Now.ToLongDateString());
                        sw.WriteLine("IMC ATUAL: " + imc_atual.Text);
                        sw.WriteLine("IMC SEU STATUS: " + textBox1status.Text);
                        sw.WriteLine("IMC IDEAL: " + imc_idael.Text);

                        



                        /* if (imcfinal > 19.1 & imcfinal < 25.8)
                         {
                           sw.WriteLine("IMC ATUAL CORRETO ");
                         }
                         else
                         {
                             sw.WriteLine("IMC IDEAL: " + imc_idael.Text);
                         }*/



                    }
                }
            }
            catch
            {
                MessageBox.Show("Erro inesperado");
            }
        }
    }
}
