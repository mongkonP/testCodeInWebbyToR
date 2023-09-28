using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0940__Sort
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/Yourownquicksort.htm
    public partial  class frmYourownquicksort:Form
    {
        public frmYourownquicksort()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmYourownquicksort
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmYourownquicksort";
            this.Text = "frmYourownquicksort";
            this.Load += new System.EventHandler(this.frmYourownquicksort_Load);
            this.ResumeLayout(false);

        }

        private void frmYourownquicksort_Load(object sender, EventArgs e)
        {

        }
    }
}
