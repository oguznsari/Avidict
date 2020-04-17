using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace AviationAcronmys
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lableInfo.Text = " To find the meaning of aviation acronym, \nclick the Search button.\n\n In order to add a new acronym to the dictionary, fill the boxes on the right hand side and click ADD button. ";
            lableInfo.Width = btnSearch.Left - lableInfo.Left + btnSearch.Width;

            comboCategory.Items.Add("CNS");
            comboCategory.Items.Add("ATC");
            comboCategory.Items.Add("Meteorology");
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("acronym.xml");

            foreach (XmlNode node in xmlDoc.DocumentElement.ChildNodes)
            {
                if (node.Name == txtSearch.Text)
                {
                        txtAcronym.Text = node.Name;
                        comboCategory.Text = node.Attributes[0].InnerText;
                        txtMeaning.Text = node.ChildNodes[0].InnerText;
                        txtDescription.Text = node.ChildNodes[1].InnerText;
                    break;
                }
                else
                {
                    txtDescription.Text = "No match, please search and add to our library";
                    txtAcronym.Text = "";
                    txtMeaning.Text = "";
                    comboCategory.Text = "";
                }
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            txtSearch.Text = null;
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnADD_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("Resources\\acronym.xml");

            XmlNode acrNode = xmlDoc.CreateElement(txtAcronym.Text);
            XmlNode meanNode = xmlDoc.CreateElement("meaning");
            XmlNode desNode = xmlDoc.CreateElement("description");
            XmlAttribute catATT = xmlDoc.CreateAttribute("category");
            catATT.Value = comboCategory.Text;
            meanNode.InnerText = txtMeaning.Text;
            desNode.InnerText = txtDescription.Text;
            acrNode.Attributes.Append(catATT);
            acrNode.AppendChild(meanNode);
            acrNode.AppendChild(desNode);
            xmlDoc.DocumentElement.AppendChild(acrNode);

            xmlDoc.Save("Resources\\acronym.xml");
        }

        private void TxtMeaning_TextChanged(object sender, EventArgs e)
        {

        }

        private void LabelMeaning_Click(object sender, EventArgs e)
        {

        }
    }
}
