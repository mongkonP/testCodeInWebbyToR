using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0260__Array_CreateInstance
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/CreateArrayWithBounds.htm
    public partial  class frmCreateArrayWithBounds:Form
    {
        public frmCreateArrayWithBounds()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreateArrayWithBounds
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreateArrayWithBounds";
            this.Text = "frmCreateArrayWithBounds";
            this.Load += new System.EventHandler(this.frmCreateArrayWithBounds_Load);
            this.ResumeLayout(false);

        }

        private void frmCreateArrayWithBounds_Load(object sender, EventArgs e)
        {

        }
    }
}
