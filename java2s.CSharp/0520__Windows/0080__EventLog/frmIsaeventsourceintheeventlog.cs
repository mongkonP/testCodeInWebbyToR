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
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/Isaeventsourceintheeventlog.htm
    public partial  class frmIsaeventsourceintheeventlog:Form
    {
        public frmIsaeventsourceintheeventlog()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmIsaeventsourceintheeventlog
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmIsaeventsourceintheeventlog";
            this.Text = "frmIsaeventsourceintheeventlog";
            this.Load += new System.EventHandler(this.frmIsaeventsourceintheeventlog_Load);
            this.ResumeLayout(false);

        }

        private void frmIsaeventsourceintheeventlog_Load(object sender, EventArgs e)
        {

        }
    }
}
