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
    //http://www.java2s.com/Tutorial/CSharp/0540__XML/FillDataSetwiththedatafromXML.htm
    public partial  class frmFillDataSetwiththedatafromXML:Form
    {
        public frmFillDataSetwiththedatafromXML()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFillDataSetwiththedatafromXML
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFillDataSetwiththedatafromXML";
            this.Text = "frmFillDataSetwiththedatafromXML";
            this.Load += new System.EventHandler(this.frmFillDataSetwiththedatafromXML_Load);
            this.ResumeLayout(false);

        }

        private void frmFillDataSetwiththedatafromXML_Load(object sender, EventArgs e)
        {

        }
    }
}
