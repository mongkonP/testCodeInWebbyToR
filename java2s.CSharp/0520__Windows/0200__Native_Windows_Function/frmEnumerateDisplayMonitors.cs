using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0520__Windows.C0200__Native_Windows_Function
{
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/EnumerateDisplayMonitors.htm
    public partial  class frmEnumerateDisplayMonitors:Form
    {
        public frmEnumerateDisplayMonitors()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmEnumerateDisplayMonitors
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmEnumerateDisplayMonitors";
            this.Text = "frmEnumerateDisplayMonitors";
            this.Load += new System.EventHandler(this.frmEnumerateDisplayMonitors_Load);
            this.ResumeLayout(false);

        }

        private void frmEnumerateDisplayMonitors_Load(object sender, EventArgs e)
        {

        }
    }
}
