using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0340__Timer
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/ATimerthatfiresonceatthespecifiedtime.htm
    public partial  class frmATimerthatfiresonceatthespecifiedtime:Form
    {
        public frmATimerthatfiresonceatthespecifiedtime()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmATimerthatfiresonceatthespecifiedtime
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmATimerthatfiresonceatthespecifiedtime";
            this.Text = "frmATimerthatfiresonceatthespecifiedtime";
            this.Load += new System.EventHandler(this.frmATimerthatfiresonceatthespecifiedtime_Load);
            this.ResumeLayout(false);

        }

        private void frmATimerthatfiresonceatthespecifiedtime_Load(object sender, EventArgs e)
        {

        }
    }
}
