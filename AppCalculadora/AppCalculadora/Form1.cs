using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCalculadora
{
    public partial class Form1 : Form
    {

        string operacion=" ";
        double numero1,numero2;
        int i = 0, igual=0;
        Boolean oper = true;
        Calculadora calcular1 = new Calculadora();


        public Form1()
        {
            InitializeComponent();
        }

        private void txt0_Click(object sender, EventArgs e)
        {
            if (txtcalculo.TextLength < 12)
            {
                txtcalculo.Text = txtcalculo.Text + "0";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnpunto_Click(object sender, EventArgs e)
        {
            if (i == 0 && txtcalculo.TextLength < 12)
            {
                txtcalculo.Text = txtcalculo.Text + ",";
                i++;
            }
        }

       

        private void btndividir_Click(object sender, EventArgs e)
        {
            if (oper && txtcalculo.Text != " ")
            {
                i = 0;
                numero1 = double.Parse(txtcalculo.Text);
                txtcalculo.Clear();
                operacion = "dividir";
                igual = 0;
                oper = false;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtcalculo.TextLength < 12)
            {
                txtcalculo.Text = txtcalculo.Text + "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtcalculo.TextLength < 12)
            {
                txtcalculo.Text = txtcalculo.Text + "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtcalculo.TextLength < 12)
            {
                txtcalculo.Text = txtcalculo.Text + "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtcalculo.TextLength < 12)
            {
                txtcalculo.Text = txtcalculo.Text + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtcalculo.TextLength < 12)
            {
                txtcalculo.Text = txtcalculo.Text + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtcalculo.TextLength < 12)
            {
                txtcalculo.Text = txtcalculo.Text + "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtcalculo.TextLength < 12)
            {
                txtcalculo.Text = txtcalculo.Text + "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtcalculo.TextLength < 12)
            {
                txtcalculo.Text = txtcalculo.Text + "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtcalculo.TextLength < 12)
            {
                txtcalculo.Text = txtcalculo.Text + "9";
            }
        }

        private void btnmultiplicar_Click(object sender, EventArgs e)
        {
            if (oper && txtcalculo.Text != "")
            {
                i = 0;
                numero1 = double.Parse(txtcalculo.Text);
                txtcalculo.Clear();
                operacion = "multiplicar";
                igual = 0;
                oper = false;
            }
        }

        private void btnmenos_Click(object sender, EventArgs e)
        {
            if (oper && txtcalculo.Text != "")
            {
                i = 0;
                numero1 = double.Parse(txtcalculo.Text);
                txtcalculo.Clear();
                operacion = "restar";
                igual = 0;
                oper = false;
            }

        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
           if(oper && txtcalculo.Text!="")
            {
                i = 0;
                numero1 = double.Parse(txtcalculo.Text);
                txtcalculo.Clear();
                operacion = "sumar";
                igual = 0;
                oper=false;
            }  
        }
        private void btnigual_Click(object sender, EventArgs e)
        {
            double resultado=0;
            if (txtcalculo.Text != "")
            {
                oper = true;
                numero2 = double.Parse(txtcalculo.Text);
                if (operacion == "sumar" && igual == 0)
                {
                    resultado = calcular1.Sumar(numero1, numero2);
                    txtcalculo.Text = resultado.ToString();
                    igual = 1;

                }
                if (operacion == "restar" && igual == 0)
                {
                    resultado = calcular1.Restar(numero1, numero2);
                    txtcalculo.Text = resultado.ToString();
                    igual = 1;

                }
                if (operacion == "multiplicar" && igual == 0)
                {
                    resultado = calcular1.Multiplicar(numero1, numero2);
                    txtcalculo.Text = resultado.ToString();
                    igual = 1;

                }
                if (operacion == "dividir" && igual == 0)
                {
                    resultado = calcular1.Dividir(numero1, numero2);
                    txtcalculo.Text = resultado.ToString();
                    igual = 1;

                }
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtcalculo.Clear();
        }

        private void txtcalculo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
                {
                    e.Handled = false;
                }
                else
                {
                    //el resto de teclas pulsadas se desactivan 
                    e.Handled = true;
                } 
        }

        private void txtcalculo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
