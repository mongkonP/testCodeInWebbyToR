using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0880__TabControl
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/TabControlandFramesource.htm
    public partial  class frmTabControlandFramesource:Form
    {
        public frmTabControlandFramesource()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTabControlandFramesource
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTabControlandFramesource";
            this.Text = "frmTabControlandFramesource";
            this.Load += new System.EventHandler(this.frmTabControlandFramesource_Load);
            this.ResumeLayout(false);

        }

        private void frmTabControlandFramesource_Load(object sender, EventArgs e)
        {

        }
    }
}
