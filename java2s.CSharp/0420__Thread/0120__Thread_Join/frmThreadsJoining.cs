using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0120__Thread_Join
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/ThreadsJoining.htm
    public partial  class frmThreadsJoining:Form
    {
        public frmThreadsJoining()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmThreadsJoining
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmThreadsJoining";
            this.Text = "frmThreadsJoining";
            this.Load += new System.EventHandler(this.frmThreadsJoining_Load);
            this.ResumeLayout(false);

        }

        private void frmThreadsJoining_Load(object sender, EventArgs e)
        {

        }
    }
}
