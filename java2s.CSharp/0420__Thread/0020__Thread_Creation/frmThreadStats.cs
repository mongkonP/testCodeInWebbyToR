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
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/ThreadStats.htm
    public partial  class frmThreadStats:Form
    {
        public frmThreadStats()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmThreadStats
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmThreadStats";
            this.Text = "frmThreadStats";
            this.Load += new System.EventHandler(this.frmThreadStats_Load);
            this.ResumeLayout(false);

        }

        private void frmThreadStats_Load(object sender, EventArgs e)
        {

        }
    }
}
