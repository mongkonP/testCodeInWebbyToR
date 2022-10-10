using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C1020__ICloneable
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/ImplementICloneableinterface.htm
    public partial  class frmImplementICloneableinterface:Form
    {
        public frmImplementICloneableinterface()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmImplementICloneableinterface
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmImplementICloneableinterface";
            this.Text = "frmImplementICloneableinterface";
            this.Load += new System.EventHandler(this.frmImplementICloneableinterface_Load);
            this.ResumeLayout(false);

        }

        private void frmImplementICloneableinterface_Load(object sender, EventArgs e)
        {

        }
    }
}
