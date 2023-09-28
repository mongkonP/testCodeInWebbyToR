using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1700__Animation
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/FourSidedBounce.htm
    public partial  class frmFourSidedBounce:Form
    {
        public frmFourSidedBounce()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFourSidedBounce
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFourSidedBounce";
            this.Text = "frmFourSidedBounce";
            this.Load += new System.EventHandler(this.frmFourSidedBounce_Load);
            this.ResumeLayout(false);

        }

        private void frmFourSidedBounce_Load(object sender, EventArgs e)
        {

        }
    }
}
