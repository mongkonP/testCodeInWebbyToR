using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0420__Mutex
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/ThreadingwithMutex.htm
    public partial  class frmThreadingwithMutex:Form
    {
        public frmThreadingwithMutex()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmThreadingwithMutex
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmThreadingwithMutex";
            this.Text = "frmThreadingwithMutex";
            this.Load += new System.EventHandler(this.frmThreadingwithMutex_Load);
            this.ResumeLayout(false);

        }

        private void frmThreadingwithMutex_Load(object sender, EventArgs e)
        {

        }
    }
}
