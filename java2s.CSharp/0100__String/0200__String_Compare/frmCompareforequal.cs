using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0100__String.C0200__String_Compare
{
    //http://www.java2s.com/Tutorial/CSharp/0100__String/Compareforequal.htm
    public partial  class frmCompareforequal:Form
    {
        public frmCompareforequal()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCompareforequal
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCompareforequal";
            this.Text = "frmCompareforequal";
            this.Load += new System.EventHandler(this.frmCompareforequal_Load);
            this.ResumeLayout(false);

        }

        private void frmCompareforequal_Load(object sender, EventArgs e)
        {

        }
    }
}
