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
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/extensionmethod.htm
    public partial  class frmextensionmethod:Form
    {
        public frmextensionmethod()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmextensionmethod
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmextensionmethod";
            this.Text = "frmextensionmethod";
            this.Load += new System.EventHandler(this.frmextensionmethod_Load);
            this.ResumeLayout(false);

        }

        private void frmextensionmethod_Load(object sender, EventArgs e)
        {

        }
    }
}