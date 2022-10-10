using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0020__Application
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/ApplicationExitevent.htm
    public partial  class frmApplicationExitevent:Form
    {
        public frmApplicationExitevent()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmApplicationExitevent
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmApplicationExitevent";
            this.Text = "frmApplicationExitevent";
            this.Load += new System.EventHandler(this.frmApplicationExitevent_Load);
            this.ResumeLayout(false);

        }

        private void frmApplicationExitevent_Load(object sender, EventArgs e)
        {

        }
    }
}
