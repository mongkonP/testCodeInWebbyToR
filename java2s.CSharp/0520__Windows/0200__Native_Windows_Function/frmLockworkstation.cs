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
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/Lockworkstation.htm
    public partial  class frmLockworkstation:Form
    {
        public frmLockworkstation()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmLockworkstation
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmLockworkstation";
            this.Text = "frmLockworkstation";
            this.Load += new System.EventHandler(this.frmLockworkstation_Load);
            this.ResumeLayout(false);

        }

        private void frmLockworkstation_Load(object sender, EventArgs e)
        {

        }
    }
}
