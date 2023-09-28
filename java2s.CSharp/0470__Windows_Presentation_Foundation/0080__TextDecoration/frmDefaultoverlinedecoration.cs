using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0080__TextDecoration
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Defaultoverlinedecoration.htm
    public partial  class frmDefaultoverlinedecoration:Form
    {
        public frmDefaultoverlinedecoration()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDefaultoverlinedecoration
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDefaultoverlinedecoration";
            this.Text = "frmDefaultoverlinedecoration";
            this.Load += new System.EventHandler(this.frmDefaultoverlinedecoration_Load);
            this.ResumeLayout(false);

        }

        private void frmDefaultoverlinedecoration_Load(object sender, EventArgs e)
        {

        }
    }
}
