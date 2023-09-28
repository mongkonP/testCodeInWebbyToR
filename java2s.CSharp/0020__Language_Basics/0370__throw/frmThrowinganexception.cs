using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0020__Language_Basics.C0370__throw
{
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/Throwinganexception.htm
    public partial  class frmThrowinganexception:Form
    {
        public frmThrowinganexception()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmThrowinganexception
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmThrowinganexception";
            this.Text = "frmThrowinganexception";
            this.Load += new System.EventHandler(this.frmThrowinganexception_Load);
            this.ResumeLayout(false);

        }

        private void frmThrowinganexception_Load(object sender, EventArgs e)
        {

        }
    }
}
