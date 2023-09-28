using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0020__Language_Basics.C0040__Documentation_Comments
{
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/XMLDocumentation.htm
    public partial  class frmXMLDocumentation:Form
    {
        public frmXMLDocumentation()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmXMLDocumentation
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmXMLDocumentation";
            this.Text = "frmXMLDocumentation";
            this.Load += new System.EventHandler(this.frmXMLDocumentation_Load);
            this.ResumeLayout(false);

        }

        private void frmXMLDocumentation_Load(object sender, EventArgs e)
        {

        }
    }
}
