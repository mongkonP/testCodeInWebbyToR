using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0580__Network.C0400__WebService
{
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/Simplestwebmethod.htm
    public partial  class frmSimplestwebmethod:Form
    {
        public frmSimplestwebmethod()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSimplestwebmethod
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSimplestwebmethod";
            this.Text = "frmSimplestwebmethod";
            this.Load += new System.EventHandler(this.frmSimplestwebmethod_Load);
            this.ResumeLayout(false);

        }

        private void frmSimplestwebmethod_Load(object sender, EventArgs e)
        {

        }
    }
}
