using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1020__Window
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/NotshowWindowinTaskbar.htm
    public partial  class frmNotshowWindowinTaskbar:Form
    {
        public frmNotshowWindowinTaskbar()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmNotshowWindowinTaskbar
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmNotshowWindowinTaskbar";
            this.Text = "frmNotshowWindowinTaskbar";
            this.Load += new System.EventHandler(this.frmNotshowWindowinTaskbar_Load);
            this.ResumeLayout(false);

        }

        private void frmNotshowWindowinTaskbar_Load(object sender, EventArgs e)
        {

        }
    }
}
