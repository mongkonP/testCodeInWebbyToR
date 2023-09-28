using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0260__Date_Time.C0020__DateTime
{
    //http://www.java2s.com/Tutorial/CSharp/0260__Date-Time/BenchmarkTimingwithDateTime.htm
    public partial  class frmBenchmarkTimingwithDateTime:Form
    {
        public frmBenchmarkTimingwithDateTime()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmBenchmarkTimingwithDateTime
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmBenchmarkTimingwithDateTime";
            this.Text = "frmBenchmarkTimingwithDateTime";
            this.Load += new System.EventHandler(this.frmBenchmarkTimingwithDateTime_Load);
            this.ResumeLayout(false);

        }

        private void frmBenchmarkTimingwithDateTime_Load(object sender, EventArgs e)
        {

        }
    }
}
