using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1300__Path
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/PathwithShadow.htm
    public partial  class frmPathwithShadow:Form
    {
        public frmPathwithShadow()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPathwithShadow
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPathwithShadow";
            this.Text = "frmPathwithShadow";
            this.Load += new System.EventHandler(this.frmPathwithShadow_Load);
            this.ResumeLayout(false);

        }

        private void frmPathwithShadow_Load(object sender, EventArgs e)
        {

        }
    }
}
