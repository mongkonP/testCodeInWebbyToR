using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0840__Padding
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/AddThicknessforPadding.htm
    public partial  class frmAddThicknessforPadding:Form
    {
        public frmAddThicknessforPadding()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddThicknessforPadding
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddThicknessforPadding";
            this.Text = "frmAddThicknessforPadding";
            this.Load += new System.EventHandler(this.frmAddThicknessforPadding_Load);
            this.ResumeLayout(false);

        }

        private void frmAddThicknessforPadding_Load(object sender, EventArgs e)
        {

        }
    }
}
