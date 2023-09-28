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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/StyleWithMultipleElements.htm
    public partial  class frmStyleWithMultipleElements:Form
    {
        public frmStyleWithMultipleElements()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmStyleWithMultipleElements
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmStyleWithMultipleElements";
            this.Text = "frmStyleWithMultipleElements";
            this.Load += new System.EventHandler(this.frmStyleWithMultipleElements_Load);
            this.ResumeLayout(false);

        }

        private void frmStyleWithMultipleElements_Load(object sender, EventArgs e)
        {

        }
    }
}
