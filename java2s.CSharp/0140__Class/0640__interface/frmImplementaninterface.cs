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
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Implementaninterface.htm
    public partial  class frmImplementaninterface:Form
    {
        public frmImplementaninterface()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmImplementaninterface
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmImplementaninterface";
            this.Text = "frmImplementaninterface";
            this.Load += new System.EventHandler(this.frmImplementaninterface_Load);
            this.ResumeLayout(false);

        }

        private void frmImplementaninterface_Load(object sender, EventArgs e)
        {

        }
    }
}
