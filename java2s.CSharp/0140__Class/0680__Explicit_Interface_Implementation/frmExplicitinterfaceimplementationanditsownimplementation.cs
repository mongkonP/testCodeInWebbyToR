using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0680__Explicit_Interface_Implementation
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Explicitinterfaceimplementationanditsownimplementation.htm
    public partial  class frmExplicitinterfaceimplementationanditsownimplementation:Form
    {
        public frmExplicitinterfaceimplementationanditsownimplementation()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmExplicitinterfaceimplementationanditsownimplementation
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmExplicitinterfaceimplementationanditsownimplementation";
            this.Text = "frmExplicitinterfaceimplementationanditsownimplementation";
            this.Load += new System.EventHandler(this.frmExplicitinterfaceimplementationanditsownimplementation_Load);
            this.ResumeLayout(false);

        }

        private void frmExplicitinterfaceimplementationanditsownimplementation_Load(object sender, EventArgs e)
        {

        }
    }
}
