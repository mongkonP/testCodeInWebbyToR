using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0940__Style
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/StyleWithMultipleButtons.htm
    public partial  class frmStyleWithMultipleButtons:Form
    {
        public frmStyleWithMultipleButtons()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmStyleWithMultipleButtons
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmStyleWithMultipleButtons";
            this.Text = "frmStyleWithMultipleButtons";
            this.Load += new System.EventHandler(this.frmStyleWithMultipleButtons_Load);
            this.ResumeLayout(false);

        }

        private void frmStyleWithMultipleButtons_Load(object sender, EventArgs e)
        {

        }
    }
}
