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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/FontPropertiesSample.htm
    public partial  class frmFontPropertiesSample:Form
    {
        public frmFontPropertiesSample()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFontPropertiesSample
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFontPropertiesSample";
            this.Text = "frmFontPropertiesSample";
            this.Load += new System.EventHandler(this.frmFontPropertiesSample_Load);
            this.ResumeLayout(false);

        }

        private void frmFontPropertiesSample_Load(object sender, EventArgs e)
        {

        }
    }
}
