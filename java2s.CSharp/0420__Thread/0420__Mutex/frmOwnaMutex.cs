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
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/OwnaMutex.htm
    public partial  class frmOwnaMutex:Form
    {
        public frmOwnaMutex()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmOwnaMutex
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmOwnaMutex";
            this.Text = "frmOwnaMutex";
            this.Load += new System.EventHandler(this.frmOwnaMutex_Load);
            this.ResumeLayout(false);

        }

        private void frmOwnaMutex_Load(object sender, EventArgs e)
        {

        }
    }
}