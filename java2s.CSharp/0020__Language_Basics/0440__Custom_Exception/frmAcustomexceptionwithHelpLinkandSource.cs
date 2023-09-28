using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0020__Language_Basics.C0440__Custom_Exception
{
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/AcustomexceptionwithHelpLinkandSource.htm
    public partial  class frmAcustomexceptionwithHelpLinkandSource:Form
    {
        public frmAcustomexceptionwithHelpLinkandSource()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAcustomexceptionwithHelpLinkandSource
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAcustomexceptionwithHelpLinkandSource";
            this.Text = "frmAcustomexceptionwithHelpLinkandSource";
            this.Load += new System.EventHandler(this.frmAcustomexceptionwithHelpLinkandSource_Load);
            this.ResumeLayout(false);

        }

        private void frmAcustomexceptionwithHelpLinkandSource_Load(object sender, EventArgs e)
        {

        }
    }
}
