using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GDG_Folha_De_Provas.Data;
using static System.Net.Mime.MediaTypeNames;

namespace GDG_Folha_De_Provas
{
    public partial class Form1 : Form
    {

        private object save_xml;


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {

            // rende o valor no windows form
            label4.Text = "Data " + textBox1.Text  +
            "\n" +
            "Numero de folhas :" + 
            textBox2.Text; label4.Refresh();

            string valor = (textBox1.Text  +  "|" + textBox2.Text);

            // guardar o ficheiro no fiechiero xml 
          // string valor_data = XmlHelper.ToXml(textBox1.Text, "C:\\\\Users\\\\heisler.lemos\\\\source\\\\repos\\\\GDG_Folha_De_Provas\\\\GDG_Folha_De_Provas\\\\output.xml\"");
            string valor_numero = XmlHelper.ToXml(valor , "objectos");

            Console.WriteLine(valor_numero) ;


            // alternativa 

            string path = "C:\\Users\\heisler.lemos\\source\\repos\\GDG_Folha_De_Provas\\GDG_Folha_De_Provas\\output.xml";

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(path))
            {
                file.Write(valor_numero + Environment.NewLine );
            }



        }
    }
}
