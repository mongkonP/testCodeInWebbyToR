using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0260__Main_Thread
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/Setmainthreadsname.htm
    public partial  class frmSetmainthreadsname:Form
    {
        public frmSetmainthreadsname()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSetmainthreadsname
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSetmainthreadsname";
            this.Text = "frmSetmainthreadsname";
            this.Load += new System.EventHandler(this.frmSetmainthreadsname_Load);
            this.ResumeLayout(false);

        }

        private void frmSetmainthreadsname_Load(object sender, EventArgs e)
        {

        }
    }
}
