using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0900__Frame
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/NavigateFrametoaURL.htm
    public partial  class frmNavigateFrametoaURL:Form
    {
        public frmNavigateFrametoaURL()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmNavigateFrametoaURL
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmNavigateFrametoaURL";
            this.Text = "frmNavigateFrametoaURL";
            this.Load += new System.EventHandler(this.frmNavigateFrametoaURL_Load);
            this.ResumeLayout(false);

        }

        private void frmNavigateFrametoaURL_Load(object sender, EventArgs e)
        {

        }
    }
}
