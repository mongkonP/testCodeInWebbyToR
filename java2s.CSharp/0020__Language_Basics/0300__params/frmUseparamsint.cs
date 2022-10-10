using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0020__Language_Basics.C0300__params
{
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/Useparamsint.htm
    public partial  class frmUseparamsint:Form
    {
        public frmUseparamsint()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseparamsint
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseparamsint";
            this.Text = "frmUseparamsint";
            this.Load += new System.EventHandler(this.frmUseparamsint_Load);
            this.ResumeLayout(false);

        }

        private void frmUseparamsint_Load(object sender, EventArgs e)
        {

        }
    }
}
