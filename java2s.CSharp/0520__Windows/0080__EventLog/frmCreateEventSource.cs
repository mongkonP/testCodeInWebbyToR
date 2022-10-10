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
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/CreateEventSource.htm
    public partial  class frmCreateEventSource:Form
    {
        public frmCreateEventSource()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreateEventSource
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreateEventSource";
            this.Text = "frmCreateEventSource";
            this.Load += new System.EventHandler(this.frmCreateEventSource_Load);
            this.ResumeLayout(false);

        }

        private void frmCreateEventSource_Load(object sender, EventArgs e)
        {

        }
    }
}
