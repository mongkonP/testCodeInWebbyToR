using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0300__Process
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/ThreadsinCurrentProcess.htm
    public partial  class frmThreadsinCurrentProcess:Form
    {
        public frmThreadsinCurrentProcess()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmThreadsinCurrentProcess
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmThreadsinCurrentProcess";
            this.Text = "frmThreadsinCurrentProcess";
            this.Load += new System.EventHandler(this.frmThreadsinCurrentProcess_Load);
            this.ResumeLayout(false);

        }

        private void frmThreadsinCurrentProcess_Load(object sender, EventArgs e)
        {

        }
    }
}
