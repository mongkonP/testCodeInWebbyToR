using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0020__Thread_Creation
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/ListthreadsforPID.htm
    public partial  class frmListthreadsforPID:Form
    {
        public frmListthreadsforPID()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmListthreadsforPID
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmListthreadsforPID";
            this.Text = "frmListthreadsforPID";
            this.Load += new System.EventHandler(this.frmListthreadsforPID_Load);
            this.ResumeLayout(false);

        }

        private void frmListthreadsforPID_Load(object sender, EventArgs e)
        {

        }
    }
}
