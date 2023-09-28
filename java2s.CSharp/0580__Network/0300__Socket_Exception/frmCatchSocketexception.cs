using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0580__Network.C0300__Socket_Exception
{
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/CatchSocketexception.htm
    public partial  class frmCatchSocketexception:Form
    {
        public frmCatchSocketexception()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCatchSocketexception
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCatchSocketexception";
            this.Text = "frmCatchSocketexception";
            this.Load += new System.EventHandler(this.frmCatchSocketexception_Load);
            this.ResumeLayout(false);

        }

        private void frmCatchSocketexception_Load(object sender, EventArgs e)
        {

        }
    }
}
