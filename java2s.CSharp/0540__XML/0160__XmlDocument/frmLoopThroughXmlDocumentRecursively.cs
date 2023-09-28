using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0540__XML.C0160__XmlDocument
{
    //http://www.java2s.com/Tutorial/CSharp/0540__XML/LoopThroughXmlDocumentRecursively.htm
    public partial  class frmLoopThroughXmlDocumentRecursively:Form
    {
        public frmLoopThroughXmlDocumentRecursively()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmLoopThroughXmlDocumentRecursively
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmLoopThroughXmlDocumentRecursively";
            this.Text = "frmLoopThroughXmlDocumentRecursively";
            this.Load += new System.EventHandler(this.frmLoopThroughXmlDocumentRecursively_Load);
            this.ResumeLayout(false);

        }

        private void frmLoopThroughXmlDocumentRecursively_Load(object sender, EventArgs e)
        {

        }
    }
}
