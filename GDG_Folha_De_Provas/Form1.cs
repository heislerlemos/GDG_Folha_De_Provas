using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GDG_Folha_De_Provas
{
    public partial class Form1 : Form
    {



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



            XmlDocument doc = new XmlDocument();
            doc.Load("C:\\Users\\heisler.lemos\\source\\repos\\GDG_Folha_De_Provas\\GDG_Folha_De_Provas\\output.xml");


            XmlNode Agendamento_de_folhas = doc.CreateElement("Agendamento_de_folhas");

            XmlNode calendario = doc.CreateElement("Calendario");
            calendario.InnerText = textBox1.Text;
            Agendamento_de_folhas.AppendChild(calendario);

            XmlNode numero = doc.CreateElement("Numero");
            numero.InnerText = textBox2.Text;
            Agendamento_de_folhas.AppendChild(numero);


            doc.DocumentElement.AppendChild(Agendamento_de_folhas);
            doc.Save("C:\\Users\\heisler.lemos\\source\\repos\\GDG_Folha_De_Provas\\GDG_Folha_De_Provas\\output.xml");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            XmlDocument doc = new XmlDocument();
            doc.Load("C:\\Users\\heisler.lemos\\source\\repos\\GDG_Folha_De_Provas\\GDG_Folha_De_Provas\\output.xml");
            Console.WriteLine(doc.DocumentElement.OuterXml);
            richTextBox1.Text = doc.DocumentElement.OuterXml;
            richTextBox1.ScrollToCaret();

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
