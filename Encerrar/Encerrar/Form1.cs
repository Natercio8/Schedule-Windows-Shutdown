using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encerrar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Btn(){
            MessageBox.Show("Estou funcionando");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        public void func(int hora)
        {
            
            if (hora != ((uint)hora))
            {
                MessageBox.Show("Tipo de parametro inválido!");
            }
            
            else
            {

                try
                {
                    int segundos = 3600; // equivale a uma
                    switch (hora)
                    {
                        case 0:
                            MessageBox.Show("O Windows encerrará em 1 minuto!");
                            Thread.Sleep(5);
                            Process.Start("shutdown", "/s /t 60");
                            break;
                        case 1:
                            MessageBox.Show("O Windows encerrará em 1 hora!");
                            Thread.Sleep(5);
                            Process.Start("shutdown", "/s /t 3600");
                            break;
                        case 2:
                            MessageBox.Show("O Windows encerrará em " + hora + " horas!");
                            Thread.Sleep(5);
                            Process.Start("shutdown", "/s /t " + segundos * hora);
                            break;

                        case 3:
                            MessageBox.Show("O Windows encerrará em " + hora + " horas!");
                            Thread.Sleep(5);
                            Process.Start("shutdown", "/s /t " + segundos * hora);
                            break;

                        case 4:
                            MessageBox.Show("O Windows encerrará em " + hora + " horas!");
                            Thread.Sleep(5);
                            Process.Start("shutdown", "/s /t " + segundos * hora);
                            break;
                        case 5:
                            MessageBox.Show("O Windows encerrará em " + hora + " horas!");
                            Thread.Sleep(5);
                            Process.Start("shutdown", "/s /t " + segundos * hora);
                            break;
                        case 6:
                            MessageBox.Show("O Windows encerrará em " + hora + " horas!");
                            Thread.Sleep(5);
                            Process.Start("shutdown", "/s /t " + segundos * hora);
                            break;
                        case 7:
                            MessageBox.Show("O Windows encerrará em " + hora + " horas!");
                            Thread.Sleep(5);
                            Process.Start("shutdown", "/s /t " + segundos * hora);
                            break;
                        case 8:
                            MessageBox.Show("O Windows encerrará em " + hora + " horas!");
                            Thread.Sleep(5);
                            Process.Start("shutdown", "/s /t " + segundos * hora);
                            break;
                        case 9:
                            MessageBox.Show("O Windows encerrará em " + hora + " horas!");
                            Thread.Sleep(5);
                            Process.Start("shutdown", "/s /t " + segundos * hora);
                            break;
                        case 10:
                            MessageBox.Show("O Windows encerrará em " + hora + " horas!");
                            Thread.Sleep(5);
                            Process.Start("shutdown", "/s /t " + segundos * hora);
                            break;
                        case 11:
                            MessageBox.Show("O Windows encerrará em " + hora + " horas!");
                            Thread.Sleep(5);
                            Process.Start("shutdown", "/s /t " + segundos * hora);
                            break;
                        case 12:
                            MessageBox.Show("O Windows encerrará em " + hora + " horas!");
                            Thread.Sleep(5);
                            Process.Start("shutdown", "/s /t " + segundos * hora);
                            break;

                    }

                }
                catch (Exception error)
                {

                    MessageBox.Show("Houve um erro inesperado: " + error);
                }
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Escolha em quantas horas a máquina vai ser encerrada\n0 significa encerramento imediato!");
            
        }

       

        private void btn_concluir_Click(object sender, EventArgs e)
        {
            int v = comboBox1.SelectedIndex;

            func(v);
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Agendamento Cancelado");
            Thread.Sleep(5);
            Process.Start("shutdown", "/a");
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
          
        }

       

        private void label5_Click(object sender, EventArgs e)
        {
            Process.Start("https://natercio.netlify.app/");
        }
    }
}
