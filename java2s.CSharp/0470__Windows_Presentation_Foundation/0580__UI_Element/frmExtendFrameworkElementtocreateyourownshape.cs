using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0580__UI_Element
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ExtendFrameworkElementtocreateyourownshape.htm
    public partial  class frmExtendFrameworkElementtocreateyourownshape:Form
    {
        public frmExtendFrameworkElementtocreateyourownshape()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmExtendFrameworkElementtocreateyourownshape
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmExtendFrameworkElementtocreateyourownshape";
            this.Text = "frmExtendFrameworkElementtocreateyourownshape";
            this.Load += new System.EventHandler(this.frmExtendFrameworkElementtocreateyourownshape_Load);
            this.ResumeLayout(false);

        }

        private void frmExtendFrameworkElementtocreateyourownshape_Load(object sender, EventArgs e)
        {

        }
    }
}
