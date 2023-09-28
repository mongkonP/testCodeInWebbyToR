using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0520__Windows.C0160__Windows_Application_Process
{
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/IEprocesses.htm
    public partial  class frmIEprocesses:Form
    {
        public frmIEprocesses()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmIEprocesses
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmIEprocesses";
            this.Text = "frmIEprocesses";
            this.Load += new System.EventHandler(this.frmIEprocesses_Load);
            this.ResumeLayout(false);

        }

        private void frmIEprocesses_Load(object sender, EventArgs e)
        {

        }
    }
}
