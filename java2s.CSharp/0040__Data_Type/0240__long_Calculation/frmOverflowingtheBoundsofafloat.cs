using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0040__Data_Type.C0240__long_Calculation
{
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/OverflowingtheBoundsofafloat.htm
    public partial  class frmOverflowingtheBoundsofafloat:Form
    {
        public frmOverflowingtheBoundsofafloat()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmOverflowingtheBoundsofafloat
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmOverflowingtheBoundsofafloat";
            this.Text = "frmOverflowingtheBoundsofafloat";
            this.Load += new System.EventHandler(this.frmOverflowingtheBoundsofafloat_Load);
            this.ResumeLayout(false);

        }

        private void frmOverflowingtheBoundsofafloat_Load(object sender, EventArgs e)
        {

        }
    }
}
