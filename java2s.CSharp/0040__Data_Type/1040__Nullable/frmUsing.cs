using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0040__Data_Type.C1040__Nullable
{
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/Using.htm
    public partial  class frmUsing:Form
    {
        public frmUsing()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsing
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsing";
            this.Text = "frmUsing";
            this.Load += new System.EventHandler(this.frmUsing_Load);
            this.ResumeLayout(false);

        }

        private void frmUsing_Load(object sender, EventArgs e)
        {

        }
    }
}
