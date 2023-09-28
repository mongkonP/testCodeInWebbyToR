using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0260__Date_Time.C0100__TimeSpan
{
    //http://www.java2s.com/Tutorial/CSharp/0260__Date-Time/ManualProfiler.htm
    public partial  class frmManualProfiler:Form
    {
        public frmManualProfiler()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmManualProfiler
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmManualProfiler";
            this.Text = "frmManualProfiler";
            this.Load += new System.EventHandler(this.frmManualProfiler_Load);
            this.ResumeLayout(false);

        }

        private void frmManualProfiler_Load(object sender, EventArgs e)
        {

        }
    }
}
