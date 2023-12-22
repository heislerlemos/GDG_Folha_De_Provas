using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;




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
            var xDoc = XDocument.Load("C:\\Users\\heisler.lemos\\source\\repos\\GDG_Folha_De_Provas\\GDG_Folha_De_Provas\\output.xml");
            var count = xDoc.Descendants("Agendamento_de_folhas").Count();
            
            var newAgendamento = new XElement("Agendamento_de_folhas",
                  new XElement("id", count + 1),
                  new XElement("Calendario", textBox1.Text),
                  new XElement("Numero", textBox2.Text));

            var calendario = newAgendamento.XPathSelectElement("Calendario");
            var Numero = newAgendamento.XPathSelectElement("Numero");


            if (calendario.Value == "Janeiro")
            {
                Console.WriteLine("Este mes ja existe será adicionado o numero");
                new XElement("Numero", textBox2.Text).Add(Numero.Value)  ;
            }


            
                   

          

            xDoc.Root.Add(newAgendamento);
            xDoc.Save("C:\\Users\\heisler.lemos\\source\\repos\\GDG_Folha_De_Provas\\GDG_Folha_De_Provas\\output.xml");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("C:\\Users\\heisler.lemos\\source\\repos\\GDG_Folha_De_Provas\\GDG_Folha_De_Provas\\output.xml");
            XmlNodeList Calendario = doc.GetElementsByTagName("Calendario");
            XmlNodeList Numero = doc.GetElementsByTagName("Numero");

            for (int i = 0; i < Calendario.Count; i++)
            {
                Console.WriteLine(Calendario[i].InnerText);
                richTextBox1.AppendText(" | " + Calendario[i].InnerText.PadRight(5) + "--->" + "  " + Numero[i].InnerText + " | " + "\n");

            }

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

        private void button3_Click(object sender, EventArgs e)
        {

            XmlDocument xmlDocument;
            xmlDocument = new XmlDocument();
            xmlDocument.Load("C:\\Users\\heisler.lemos\\source\\repos\\GDG_Folha_De_Provas\\GDG_Folha_De_Provas\\output.xml");
            string input = textBox3.Text;
            foreach (XmlNode xmlElement in xmlDocument.DocumentElement.SelectNodes($"Agendamento_de_folhas[Calendario='{input}']"))
            {
            Console.Out.WriteLine(xmlElement.InnerText);
            richTextBox2.Text = "Numero de folhas disponiveis : " +  xmlElement.ChildNodes[2].InnerText;
            }
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

           richTextBox2.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";

        }
    }
}
