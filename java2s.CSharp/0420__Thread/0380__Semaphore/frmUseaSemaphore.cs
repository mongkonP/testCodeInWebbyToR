using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0380__Semaphore
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/UseaSemaphore.htm
    public partial  class frmUseaSemaphore:Form
    {
        public frmUseaSemaphore()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseaSemaphore
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseaSemaphore";
            this.Text = "frmUseaSemaphore";
            this.Load += new System.EventHandler(this.frmUseaSemaphore_Load);
            this.ResumeLayout(false);

        }

        private void frmUseaSemaphore_Load(object sender, EventArgs e)
        {

        }
    }
}
