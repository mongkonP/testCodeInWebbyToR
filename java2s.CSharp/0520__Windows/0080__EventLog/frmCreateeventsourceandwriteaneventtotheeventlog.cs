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
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/Createeventsourceandwriteaneventtotheeventlog.htm
    public partial  class frmCreateeventsourceandwriteaneventtotheeventlog:Form
    {
        public frmCreateeventsourceandwriteaneventtotheeventlog()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreateeventsourceandwriteaneventtotheeventlog
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreateeventsourceandwriteaneventtotheeventlog";
            this.Text = "frmCreateeventsourceandwriteaneventtotheeventlog";
            this.Load += new System.EventHandler(this.frmCreateeventsourceandwriteaneventtotheeventlog_Load);
            this.ResumeLayout(false);

        }

        private void frmCreateeventsourceandwriteaneventtotheeventlog_Load(object sender, EventArgs e)
        {

        }
    }
}
