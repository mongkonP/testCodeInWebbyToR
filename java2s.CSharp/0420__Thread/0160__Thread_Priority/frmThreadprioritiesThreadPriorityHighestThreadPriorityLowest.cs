using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0160__Thread_Priority
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/ThreadprioritiesThreadPriorityHighestThreadPriorityLowest.htm
    public partial  class frmThreadprioritiesThreadPriorityHighestThreadPriorityLowest:Form
    {
        public frmThreadprioritiesThreadPriorityHighestThreadPriorityLowest()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmThreadprioritiesThreadPriorityHighestThreadPriorityLowest
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmThreadprioritiesThreadPriorityHighestThreadPriorityLowest";
            this.Text = "frmThreadprioritiesThreadPriorityHighestThreadPriorityLowest";
            this.Load += new System.EventHandler(this.frmThreadprioritiesThreadPriorityHighestThreadPriorityLowest_Load);
            this.ResumeLayout(false);

        }

        private void frmThreadprioritiesThreadPriorityHighestThreadPriorityLowest_Load(object sender, EventArgs e)
        {

        }
    }
}
