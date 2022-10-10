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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/StyleWithResource.htm
    public partial  class frmStyleWithResource:Form
    {
        public frmStyleWithResource()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmStyleWithResource
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmStyleWithResource";
            this.Text = "frmStyleWithResource";
            this.Load += new System.EventHandler(this.frmStyleWithResource_Load);
            this.ResumeLayout(false);

        }

        private void frmStyleWithResource_Load(object sender, EventArgs e)
        {

        }
    }
}
