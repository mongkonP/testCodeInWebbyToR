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
    //http://www.java2s.com/Tutorial/CSharp/0540__XML/OutputDataSettoXml.htm
    public partial  class frmOutputDataSettoXml:Form
    {
        public frmOutputDataSettoXml()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmOutputDataSettoXml
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmOutputDataSettoXml";
            this.Text = "frmOutputDataSettoXml";
            this.Load += new System.EventHandler(this.frmOutputDataSettoXml_Load);
            this.ResumeLayout(false);

        }

        private void frmOutputDataSettoXml_Load(object sender, EventArgs e)
        {

        }
    }
}
