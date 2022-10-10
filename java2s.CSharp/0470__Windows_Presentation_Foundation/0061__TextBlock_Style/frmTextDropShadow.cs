using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0061__TextBlock_Style
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/TextDropShadow.htm
    public partial  class frmTextDropShadow:Form
    {
        public frmTextDropShadow()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTextDropShadow
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTextDropShadow";
            this.Text = "frmTextDropShadow";
            this.Load += new System.EventHandler(this.frmTextDropShadow_Load);
            this.ResumeLayout(false);

        }

        private void frmTextDropShadow_Load(object sender, EventArgs e)
        {

        }
    }
}
