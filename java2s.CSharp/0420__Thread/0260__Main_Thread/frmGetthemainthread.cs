using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0260__Main_Thread
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/Getthemainthread.htm
    public partial  class frmGetthemainthread:Form
    {
        public frmGetthemainthread()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetthemainthread
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetthemainthread";
            this.Text = "frmGetthemainthread";
            this.Load += new System.EventHandler(this.frmGetthemainthread_Load);
            this.ResumeLayout(false);

        }

        private void frmGetthemainthread_Load(object sender, EventArgs e)
        {

        }
    }
}
