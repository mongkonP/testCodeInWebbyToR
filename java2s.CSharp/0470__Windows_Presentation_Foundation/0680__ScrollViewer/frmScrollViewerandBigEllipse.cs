using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0680__ScrollViewer
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ScrollViewerandBigEllipse.htm
    public partial  class frmScrollViewerandBigEllipse:Form
    {
        public frmScrollViewerandBigEllipse()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmScrollViewerandBigEllipse
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmScrollViewerandBigEllipse";
            this.Text = "frmScrollViewerandBigEllipse";
            this.Load += new System.EventHandler(this.frmScrollViewerandBigEllipse_Load);
            this.ResumeLayout(false);

        }

        private void frmScrollViewerandBigEllipse_Load(object sender, EventArgs e)
        {

        }
    }
}
