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
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/Displaymainthreadspriority.htm
    public partial  class frmDisplaymainthreadspriority:Form
    {
        public frmDisplaymainthreadspriority()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDisplaymainthreadspriority
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDisplaymainthreadspriority";
            this.Text = "frmDisplaymainthreadspriority";
            this.Load += new System.EventHandler(this.frmDisplaymainthreadspriority_Load);
            this.ResumeLayout(false);

        }

        private void frmDisplaymainthreadspriority_Load(object sender, EventArgs e)
        {

        }
    }
}
