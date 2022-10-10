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
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/InterfaceProperties.htm
    public partial  class frmInterfaceProperties:Form
    {
        public frmInterfaceProperties()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmInterfaceProperties
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmInterfaceProperties";
            this.Text = "frmInterfaceProperties";
            this.Load += new System.EventHandler(this.frmInterfaceProperties_Load);
            this.ResumeLayout(false);

        }

        private void frmInterfaceProperties_Load(object sender, EventArgs e)
        {

        }
    }
}
