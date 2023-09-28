using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1400__Font
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/FontPropertiesMoved.htm
    public partial  class frmFontPropertiesMoved:Form
    {
        public frmFontPropertiesMoved()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFontPropertiesMoved
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFontPropertiesMoved";
            this.Text = "frmFontPropertiesMoved";
            this.Load += new System.EventHandler(this.frmFontPropertiesMoved_Load);
            this.ResumeLayout(false);

        }

        private void frmFontPropertiesMoved_Load(object sender, EventArgs e)
        {

        }
    }
}
