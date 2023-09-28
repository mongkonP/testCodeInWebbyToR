using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0780__Stack
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/Clearastack.htm
    public partial  class frmClearastack:Form
    {
        public frmClearastack()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmClearastack
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmClearastack";
            this.Text = "frmClearastack";
            this.Load += new System.EventHandler(this.frmClearastack_Load);
            this.ResumeLayout(false);

        }

        private void frmClearastack_Load(object sender, EventArgs e)
        {

        }
    }
}
