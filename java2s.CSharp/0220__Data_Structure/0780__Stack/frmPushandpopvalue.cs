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
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/Pushandpopvalue.htm
    public partial  class frmPushandpopvalue:Form
    {
        public frmPushandpopvalue()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPushandpopvalue
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPushandpopvalue";
            this.Text = "frmPushandpopvalue";
            this.Load += new System.EventHandler(this.frmPushandpopvalue_Load);
            this.ResumeLayout(false);

        }

        private void frmPushandpopvalue_Load(object sender, EventArgs e)
        {

        }
    }
}
