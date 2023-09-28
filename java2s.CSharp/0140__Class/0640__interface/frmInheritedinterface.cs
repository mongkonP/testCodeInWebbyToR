using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0640__interface
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Inheritedinterface.htm
    public partial  class frmInheritedinterface:Form
    {
        public frmInheritedinterface()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmInheritedinterface
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmInheritedinterface";
            this.Text = "frmInheritedinterface";
            this.Load += new System.EventHandler(this.frmInheritedinterface_Load);
            this.ResumeLayout(false);

        }

        private void frmInheritedinterface_Load(object sender, EventArgs e)
        {

        }
    }
}
