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
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/Displaymainthreadsname.htm
    public partial  class frmDisplaymainthreadsname:Form
    {
        public frmDisplaymainthreadsname()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDisplaymainthreadsname
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDisplaymainthreadsname";
            this.Text = "frmDisplaymainthreadsname";
            this.Load += new System.EventHandler(this.frmDisplaymainthreadsname_Load);
            this.ResumeLayout(false);

        }

        private void frmDisplaymainthreadsname_Load(object sender, EventArgs e)
        {

        }
    }
}
