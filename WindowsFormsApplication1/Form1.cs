using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void documentViewer1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                var report = new XtraReport2();
                documentViewer1.DocumentSource = report;
                documentViewer1.InitiateDocumentCreation();
            }
            else if (radioButton1.Checked)
            {
                var report = new XtraReport1();
                documentViewer1.DocumentSource = report;
                documentViewer1.InitiateDocumentCreation();
            }
        }
    }
}
