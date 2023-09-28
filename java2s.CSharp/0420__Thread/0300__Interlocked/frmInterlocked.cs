using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0300__Interlocked
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/Interlocked.htm
    public partial  class frmInterlocked:Form
    {
        public frmInterlocked()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmInterlocked
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmInterlocked";
            this.Text = "frmInterlocked";
            this.Load += new System.EventHandler(this.frmInterlocked_Load);
            this.ResumeLayout(false);

        }

        private void frmInterlocked_Load(object sender, EventArgs e)
        {

        }
    }
}
