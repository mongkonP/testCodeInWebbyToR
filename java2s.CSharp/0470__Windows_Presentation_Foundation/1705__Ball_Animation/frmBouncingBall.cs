using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1705__Ball_Animation
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/BouncingBall.htm
    public partial  class frmBouncingBall:Form
    {
        public frmBouncingBall()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmBouncingBall
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmBouncingBall";
            this.Text = "frmBouncingBall";
            this.Load += new System.EventHandler(this.frmBouncingBall_Load);
            this.ResumeLayout(false);

        }

        private void frmBouncingBall_Load(object sender, EventArgs e)
        {

        }
    }
}
