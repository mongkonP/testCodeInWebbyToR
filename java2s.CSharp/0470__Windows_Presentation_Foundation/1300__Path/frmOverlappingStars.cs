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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/OverlappingStars.htm
    public partial  class frmOverlappingStars:Form
    {
        public frmOverlappingStars()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmOverlappingStars
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmOverlappingStars";
            this.Text = "frmOverlappingStars";
            this.Load += new System.EventHandler(this.frmOverlappingStars_Load);
            this.ResumeLayout(false);

        }

        private void frmOverlappingStars_Load(object sender, EventArgs e)
        {

        }
    }
}
