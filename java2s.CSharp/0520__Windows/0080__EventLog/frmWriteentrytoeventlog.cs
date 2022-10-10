using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0520__Windows.C0080__EventLog
{
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/Writeentrytoeventlog.htm
    public partial  class frmWriteentrytoeventlog:Form
    {
        public frmWriteentrytoeventlog()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmWriteentrytoeventlog
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmWriteentrytoeventlog";
            this.Text = "frmWriteentrytoeventlog";
            this.Load += new System.EventHandler(this.frmWriteentrytoeventlog_Load);
            this.ResumeLayout(false);

        }

        private void frmWriteentrytoeventlog_Load(object sender, EventArgs e)
        {

        }
    }
}
