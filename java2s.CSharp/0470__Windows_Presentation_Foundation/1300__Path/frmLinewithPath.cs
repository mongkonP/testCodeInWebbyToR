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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/LinewithPath.htm
    public partial  class frmLinewithPath:Form
    {
        public frmLinewithPath()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmLinewithPath
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmLinewithPath";
            this.Text = "frmLinewithPath";
            this.Load += new System.EventHandler(this.frmLinewithPath_Load);
            this.ResumeLayout(false);

        }

        private void frmLinewithPath_Load(object sender, EventArgs e)
        {

        }
    }
}
