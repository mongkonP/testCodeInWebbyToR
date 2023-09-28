using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0200__Label
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/EmbeddedFont.htm
    public partial  class frmEmbeddedFont:Form
    {
        public frmEmbeddedFont()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmEmbeddedFont
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmEmbeddedFont";
            this.Text = "frmEmbeddedFont";
            this.Load += new System.EventHandler(this.frmEmbeddedFont_Load);
            this.ResumeLayout(false);

        }

        private void frmEmbeddedFont_Load(object sender, EventArgs e)
        {

        }
    }
}
