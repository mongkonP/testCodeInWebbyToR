using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0580__ThreadPool
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/ThreadPoolExample.htm
    public partial  class frmThreadPoolExample:Form
    {
        public frmThreadPoolExample()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmThreadPoolExample
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmThreadPoolExample";
            this.Text = "frmThreadPoolExample";
            this.Load += new System.EventHandler(this.frmThreadPoolExample_Load);
            this.ResumeLayout(false);

        }

        private void frmThreadPoolExample_Load(object sender, EventArgs e)
        {

        }
    }
}
