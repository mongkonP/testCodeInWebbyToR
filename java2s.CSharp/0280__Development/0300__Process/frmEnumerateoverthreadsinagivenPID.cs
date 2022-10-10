using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0300__Process
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/EnumerateoverthreadsinagivenPID.htm
    public partial  class frmEnumerateoverthreadsinagivenPID:Form
    {
        public frmEnumerateoverthreadsinagivenPID()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmEnumerateoverthreadsinagivenPID
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmEnumerateoverthreadsinagivenPID";
            this.Text = "frmEnumerateoverthreadsinagivenPID";
            this.Load += new System.EventHandler(this.frmEnumerateoverthreadsinagivenPID_Load);
            this.ResumeLayout(false);

        }

        private void frmEnumerateoverthreadsinagivenPID_Load(object sender, EventArgs e)
        {

        }
    }
}
