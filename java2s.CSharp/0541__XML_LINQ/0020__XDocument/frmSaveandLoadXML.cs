using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0541__XML_LINQ.C0020__XDocument
{
    //http://www.java2s.com/Tutorial/CSharp/0541__XML-LINQ/SaveandLoadXML.htm
    public partial  class frmSaveandLoadXML:Form
    {
        public frmSaveandLoadXML()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSaveandLoadXML
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSaveandLoadXML";
            this.Text = "frmSaveandLoadXML";
            this.Load += new System.EventHandler(this.frmSaveandLoadXML_Load);
            this.ResumeLayout(false);

        }

        private void frmSaveandLoadXML_Load(object sender, EventArgs e)
        {

        }
    }
}
