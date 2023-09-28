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
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/DisplayFirst5EntriesinyoursystemEventlog.htm
    public partial  class frmDisplayFirst5EntriesinyoursystemEventlog:Form
    {
        public frmDisplayFirst5EntriesinyoursystemEventlog()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDisplayFirst5EntriesinyoursystemEventlog
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDisplayFirst5EntriesinyoursystemEventlog";
            this.Text = "frmDisplayFirst5EntriesinyoursystemEventlog";
            this.Load += new System.EventHandler(this.frmDisplayFirst5EntriesinyoursystemEventlog_Load);
            this.ResumeLayout(false);

        }

        private void frmDisplayFirst5EntriesinyoursystemEventlog_Load(object sender, EventArgs e)
        {

        }
    }
}
