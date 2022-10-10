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
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/InterfaceExplicitImplementation.htm
    public partial  class frmInterfaceExplicitImplementation:Form
    {
        public frmInterfaceExplicitImplementation()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmInterfaceExplicitImplementation
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmInterfaceExplicitImplementation";
            this.Text = "frmInterfaceExplicitImplementation";
            this.Load += new System.EventHandler(this.frmInterfaceExplicitImplementation_Load);
            this.ResumeLayout(false);

        }

        private void frmInterfaceExplicitImplementation_Load(object sender, EventArgs e)
        {

        }
    }
}
