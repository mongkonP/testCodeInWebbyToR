using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0420__Mutex
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/NameaMutex.htm
    public partial  class frmNameaMutex:Form
    {
        public frmNameaMutex()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmNameaMutex
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmNameaMutex";
            this.Text = "frmNameaMutex";
            this.Load += new System.EventHandler(this.frmNameaMutex_Load);
            this.ResumeLayout(false);

        }

        private void frmNameaMutex_Load(object sender, EventArgs e)
        {

        }
    }
}
