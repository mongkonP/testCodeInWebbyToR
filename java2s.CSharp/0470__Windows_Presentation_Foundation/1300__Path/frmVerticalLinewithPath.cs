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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/VerticalLinewithPath.htm
    public partial  class frmVerticalLinewithPath:Form
    {
        public frmVerticalLinewithPath()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmVerticalLinewithPath
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmVerticalLinewithPath";
            this.Text = "frmVerticalLinewithPath";
            this.Load += new System.EventHandler(this.frmVerticalLinewithPath_Load);
            this.ResumeLayout(false);

        }

        private void frmVerticalLinewithPath_Load(object sender, EventArgs e)
        {

        }
    }
}
