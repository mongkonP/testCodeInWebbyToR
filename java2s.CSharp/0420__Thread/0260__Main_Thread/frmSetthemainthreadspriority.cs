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
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/Setthemainthreadspriority.htm
    public partial  class frmSetthemainthreadspriority:Form
    {
        public frmSetthemainthreadspriority()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSetthemainthreadspriority
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSetthemainthreadspriority";
            this.Text = "frmSetthemainthreadspriority";
            this.Load += new System.EventHandler(this.frmSetthemainthreadspriority_Load);
            this.ResumeLayout(false);

        }

        private void frmSetthemainthreadspriority_Load(object sender, EventArgs e)
        {

        }
    }
}
