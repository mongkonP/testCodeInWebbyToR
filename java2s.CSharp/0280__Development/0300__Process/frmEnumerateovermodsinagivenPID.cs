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
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/EnumerateovermodsinagivenPID.htm
    public partial  class frmEnumerateovermodsinagivenPID:Form
    {
        public frmEnumerateovermodsinagivenPID()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmEnumerateovermodsinagivenPID
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmEnumerateovermodsinagivenPID";
            this.Text = "frmEnumerateovermodsinagivenPID";
            this.Load += new System.EventHandler(this.frmEnumerateovermodsinagivenPID_Load);
            this.ResumeLayout(false);

        }

        private void frmEnumerateovermodsinagivenPID_Load(object sender, EventArgs e)
        {

        }
    }
}
