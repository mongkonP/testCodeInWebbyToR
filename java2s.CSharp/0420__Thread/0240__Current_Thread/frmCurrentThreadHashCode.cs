using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0240__Current_Thread
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/CurrentThreadHashCode.htm
    public partial  class frmCurrentThreadHashCode:Form
    {
        public frmCurrentThreadHashCode()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCurrentThreadHashCode
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCurrentThreadHashCode";
            this.Text = "frmCurrentThreadHashCode";
            this.Load += new System.EventHandler(this.frmCurrentThreadHashCode_Load);
            this.ResumeLayout(false);

        }

        private void frmCurrentThreadHashCode_Load(object sender, EventArgs e)
        {

        }
    }
}
