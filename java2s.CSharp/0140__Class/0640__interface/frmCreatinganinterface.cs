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
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Creatinganinterface.htm
    public partial  class frmCreatinganinterface:Form
    {
        public frmCreatinganinterface()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreatinganinterface
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreatinganinterface";
            this.Text = "frmCreatinganinterface";
            this.Load += new System.EventHandler(this.frmCreatinganinterface_Load);
            this.ResumeLayout(false);

        }

        private void frmCreatinganinterface_Load(object sender, EventArgs e)
        {

        }
    }
}
