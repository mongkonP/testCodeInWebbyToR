using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0540__XML.C0460__Xml_DataSet
{
    //http://www.java2s.com/Tutorial/CSharp/0540__XML/ReadingXMLwithDataSet.htm
    public partial  class frmReadingXMLwithDataSet:Form
    {
        public frmReadingXMLwithDataSet()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReadingXMLwithDataSet
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReadingXMLwithDataSet";
            this.Text = "frmReadingXMLwithDataSet";
            this.Load += new System.EventHandler(this.frmReadingXMLwithDataSet_Load);
            this.ResumeLayout(false);

        }

        private void frmReadingXMLwithDataSet_Load(object sender, EventArgs e)
        {

        }
    }
}
