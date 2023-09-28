using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0540__XML.C0100__XmlReader
{
    //http://www.java2s.com/Tutorial/CSharp/0540__XML/ReadXmloutputfromdatabase.htm
    public partial  class frmReadXmloutputfromdatabase:Form
    {
        public frmReadXmloutputfromdatabase()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReadXmloutputfromdatabase
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReadXmloutputfromdatabase";
            this.Text = "frmReadXmloutputfromdatabase";
            this.Load += new System.EventHandler(this.frmReadXmloutputfromdatabase_Load);
            this.ResumeLayout(false);

        }

        private void frmReadXmloutputfromdatabase_Load(object sender, EventArgs e)
        {

        }
    }
}
