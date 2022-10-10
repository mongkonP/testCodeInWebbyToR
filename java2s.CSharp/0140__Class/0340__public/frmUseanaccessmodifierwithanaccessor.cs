using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0340__public
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Useanaccessmodifierwithanaccessor.htm
    public partial  class frmUseanaccessmodifierwithanaccessor:Form
    {
        public frmUseanaccessmodifierwithanaccessor()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseanaccessmodifierwithanaccessor
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseanaccessmodifierwithanaccessor";
            this.Text = "frmUseanaccessmodifierwithanaccessor";
            this.Load += new System.EventHandler(this.frmUseanaccessmodifierwithanaccessor_Load);
            this.ResumeLayout(false);

        }

        private void frmUseanaccessmodifierwithanaccessor_Load(object sender, EventArgs e)
        {

        }
    }
}
