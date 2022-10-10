using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0860__IEnumerable
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/IteratorBlockIterationSample.htm
    public partial  class frmIteratorBlockIterationSample:Form
    {
        public frmIteratorBlockIterationSample()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmIteratorBlockIterationSample
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmIteratorBlockIterationSample";
            this.Text = "frmIteratorBlockIterationSample";
            this.Load += new System.EventHandler(this.frmIteratorBlockIterationSample_Load);
            this.ResumeLayout(false);

        }

        private void frmIteratorBlockIterationSample_Load(object sender, EventArgs e)
        {

        }
    }
}
