using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C1160__Extension
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/ExtensionMethods.htm
    public partial  class frmExtensionMethods:Form
    {
        public frmExtensionMethods()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmExtensionMethods
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmExtensionMethods";
            this.Text = "frmExtensionMethods";
            this.Load += new System.EventHandler(this.frmExtensionMethods_Load);
            this.ResumeLayout(false);

        }

        private void frmExtensionMethods_Load(object sender, EventArgs e)
        {

        }
    }
}
