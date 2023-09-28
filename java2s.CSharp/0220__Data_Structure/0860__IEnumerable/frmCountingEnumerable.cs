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
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/CountingEnumerable.htm
    public partial  class frmCountingEnumerable:Form
    {
        public frmCountingEnumerable()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCountingEnumerable
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCountingEnumerable";
            this.Text = "frmCountingEnumerable";
            this.Load += new System.EventHandler(this.frmCountingEnumerable_Load);
            this.ResumeLayout(false);

        }

        private void frmCountingEnumerable_Load(object sender, EventArgs e)
        {

        }
    }
}
