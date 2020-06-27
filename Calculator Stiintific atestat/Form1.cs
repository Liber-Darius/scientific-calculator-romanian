using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Stiintific_atestat
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string operator1 = string.Empty;
        string operator2 = string.Empty;
        char operatie;
        double rezultat = 0.0;
        public Form1()
        {
            InitializeComponent();
        }

       double DegreesToRadians(double degrees)
{
   return degrees * 3.1416/ 180.0;
}

        private void Caluleazabuton_Click(object sender, EventArgs e)
        {
            operator2 = input;
            double num1, num2;
            double.TryParse(operator1, out num1);
            double.TryParse(operator2, out num2);

            if (operatie == '+')
            {
                rezultat = num1 + num2;
                textBox1.Text = rezultat.ToString();
            }
            else if (operatie == '-')
            {
                rezultat = num1 - num2;
                textBox1.Text = rezultat.ToString();
            }
            else if (operatie == '*')
            {
                rezultat = num1 * num2;
                textBox1.Text = rezultat.ToString();
            }
            else if (operatie == '/')
            {
                if (num2 != 0)
                {
                    rezultat = num1 / num2;
                    textBox1.Text = rezultat.ToString();
                }
                else
                {
                    textBox1.Text = "nu poti imparti la zero";
                }

            }
        }

        private void Buton5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "5";
            this.textBox1.Text += input;
        }

        private void Buton1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "1";
            this.textBox1.Text += input;
        }

        private void Buton2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "2";
            this.textBox1.Text += input;
        }

        private void Buton3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "3";
            this.textBox1.Text += input;
        }

        private void Inmultire_Click(object sender, EventArgs e)
        {
            operator1 = input;
            operatie = '*';
            input = string.Empty;
        }

        private void Buton4_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "4";
            this.textBox1.Text += input;
        }

        private void Buton6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "6";
            this.textBox1.Text += input;
        }

        private void Adunare_Click(object sender, EventArgs e)
        {
            operator1 = input;
            operatie = '+';
            input = string.Empty;
        }

        private void Buton7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "7";
            this.textBox1.Text += input;
        }

        private void Buton8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "8";
            this.textBox1.Text += input;
        }

        private void Buton9_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "9";
            this.textBox1.Text += input;
        }

        private void Scadere_Click(object sender, EventArgs e)
        {
            operator1 = input;
            operatie = '-';
            input = string.Empty;
        }

        private void Buton0_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "0";
            this.textBox1.Text += input;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += ".";
            this.textBox1.Text += input;
        }

        private void Sterge_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.input = string.Empty;
            this.operator1 = string.Empty;
            this.operator2 = string.Empty;
        }

        private void Impartire_Click(object sender, EventArgs e)
        {
            operator1 = input;
            operatie = '/';
            input = string.Empty;
        }

        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ModToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void GeometrieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void Button17_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Sin_Click(object sender, EventArgs e)
        {

            textBox6.Text = Convert.ToString(Math.Round(Math.Sin(DegreesToRadians(Convert.ToDouble(textBox2.Text))), 4));
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cos_Click(object sender, EventArgs e)

        {
            textBox7.Text = Convert.ToString(Math.Round(Math.Cos(DegreesToRadians(Convert.ToDouble(textBox2.Text))), 4));
        }

        private void Tg_Click(object sender, EventArgs e)
        {
            int rezultatu = int.Parse(textBox2.Text);
            if (rezultatu % 90 == 0 && (rezultatu/90) %2 == 1) textBox5.Text = "nu exista";
            else  textBox5.Text = Convert.ToString(Math.Round(Math.Tan(DegreesToRadians(Convert.ToInt32(textBox2.Text))), 4));
        }

        private void Ctg_Click(object sender, EventArgs e)
        {
            double rezultatu = int.Parse(textBox2.Text);
            if (rezultatu % 90 == 0 && (rezultatu / 90) % 2 == 0) textBox4.Text = "nu exista";
            else
            {
                double cosu = Math.Cos(DegreesToRadians(Convert.ToDouble(textBox2.Text)));
                double sinu = Math.Sin(DegreesToRadians(Convert.ToDouble(textBox2.Text)));

                textBox4.Text = Convert.ToString(Math.Round((cosu / sinu),4));
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void ConversiiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;


        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void NormalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }

      

        private void Convertestebuton_Click(object sender, EventArgs e)
        {
            textBox8.Text = "";
            if (listBox1.SelectedItem == "centimetri" && listBox2.SelectedItem == "inchi")
                textBox8.Text = (double.Parse(textBox3.Text) * 0.3937).ToString();
            else if (listBox1.SelectedItem == "grade Celsius" && listBox2.SelectedItem == "grade Fahrenheit")
                textBox8.Text = (double.Parse(textBox3.Text) * 1.8 + 32).ToString();
            else if (listBox1.SelectedItem == "metri patrati" && listBox2.SelectedItem == "ari")
                textBox8.Text = (double.Parse(textBox3.Text) / 100).ToString();
            else if (listBox1.SelectedItem == "secunde" && listBox2.SelectedItem == "minute")
                textBox8.Text = (double.Parse(textBox3.Text) / 60).ToString();
            else if (listBox1.SelectedItem == "calorii" && listBox2.SelectedItem == "Jouli")
                textBox8.Text = (double.Parse(textBox3.Text) * 4.1868).ToString();
            else if (listBox1.SelectedItem == "grame" && listBox2.SelectedItem == "kilograme")
                textBox8.Text = (double.Parse(textBox3.Text) * 1000).ToString();
            else MessageBox.Show("introdu o conversie valida");

        }

        private void Rezulatule_TextChanged(object sender, EventArgs e)
        {

        }

        private void Initialule_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox8.Text = "";
        }

        private void ListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
