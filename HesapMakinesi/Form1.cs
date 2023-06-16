using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        bool optDurum = false;
        double result = 0;
        string opt = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void result_Button_Click(object sender, EventArgs e)
        {
            sonuc_Label.Text = "";
            optDurum = true;
            switch (opt)
            {
                case "+":
                    ekranLabel.Text = (result + Double.Parse(ekranLabel.Text)).ToString();
                    break;
                case "-":
                    ekranLabel.Text = (result - Double.Parse(ekranLabel.Text)).ToString();
                    break;
                case "x":
                    ekranLabel.Text = (result * Double.Parse(ekranLabel.Text)).ToString();
                    break;
                case "/":
                    ekranLabel.Text = (result / Double.Parse(ekranLabel.Text)).ToString();
                    break;

            }
            result = Double.Parse(ekranLabel.Text);
            ekranLabel.Text = result.ToString();
            opt = " ";

        }

        private void decal_Button_Click(object sender, EventArgs e)
        {

        }

        private void RakamOlay(object sender, EventArgs e)
        {
            if(ekranLabel.Text == "0" || optDurum)
            {
                ekranLabel.Text = " ";
            }
            optDurum= false;

            Button btn = (Button)sender;
            ekranLabel.Text += btn.Text;

        }

        private void OptIslem(object sender, EventArgs e)
        {
            optDurum = true;
            Button btn = (Button)sender;
            string yeniOpt = btn.Text; //bir önceki operatör işlemi
            sonuc_Label.Text = sonuc_Label.Text + " " + ekranLabel.Text + " " + yeniOpt;

            switch (opt)
            {
                case "+":
                    ekranLabel.Text = (result + Double.Parse(ekranLabel.Text)).ToString();
                    break;
                case "-":
                    ekranLabel.Text = (result - Double.Parse(ekranLabel.Text)).ToString();
                    break;
                case "x":
                    ekranLabel.Text = (result * Double.Parse(ekranLabel.Text)).ToString();
                    break;
                case "/":
                    ekranLabel.Text = (result / Double.Parse(ekranLabel.Text)).ToString();
                    break;

            }
            result = Double.Parse(ekranLabel.Text);
            ekranLabel.Text = result.ToString();
            opt = yeniOpt;
        }

        private void CE_Button_Click(object sender, EventArgs e)
        {
            ekranLabel.Text = "0";
        }

        private void C_Button_Click(object sender, EventArgs e)
        {
            ekranLabel.Text = "0";
            sonuc_Label.Text = "";
            opt = "";
            result = 0;
            optDurum = false;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if(ekranLabel.Text == "0")
            {
                ekranLabel.Text = "0";
            }
            else if(optDurum)
            {
                ekranLabel.Text = "0";
            }

            if (!ekranLabel.Text.Contains(","))
            {
                ekranLabel.Text += ",";
            }
            optDurum = false;
        }
    }
}
