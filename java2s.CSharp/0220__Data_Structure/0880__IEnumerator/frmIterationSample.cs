using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0880__IEnumerator
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/IterationSample.htm
    public partial  class frmIterationSample:Form
    {
        public frmIterationSample()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmIterationSample
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmIterationSample";
            this.Text = "frmIterationSample";
            this.Load += new System.EventHandler(this.frmIterationSample_Load);
            this.ResumeLayout(false);

        }

        private void frmIterationSample_Load(object sender, EventArgs e)
        {

        }
    }
}
