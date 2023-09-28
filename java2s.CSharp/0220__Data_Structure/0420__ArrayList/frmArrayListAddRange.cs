using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0420__ArrayList
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/ArrayListAddRange.htm
    public partial  class frmArrayListAddRange:Form
    {
        public frmArrayListAddRange()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmArrayListAddRange
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmArrayListAddRange";
            this.Text = "frmArrayListAddRange";
            this.Load += new System.EventHandler(this.frmArrayListAddRange_Load);
            this.ResumeLayout(false);

        }

        private void frmArrayListAddRange_Load(object sender, EventArgs e)
        {

        }
    }
}
