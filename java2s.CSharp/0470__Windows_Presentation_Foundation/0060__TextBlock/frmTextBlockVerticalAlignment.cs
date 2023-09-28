using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0060__TextBlock
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/TextBlockVerticalAlignment.htm
    public partial  class frmTextBlockVerticalAlignment:Form
    {
        public frmTextBlockVerticalAlignment()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTextBlockVerticalAlignment
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTextBlockVerticalAlignment";
            this.Text = "frmTextBlockVerticalAlignment";
            this.Load += new System.EventHandler(this.frmTextBlockVerticalAlignment_Load);
            this.ResumeLayout(false);

        }

        private void frmTextBlockVerticalAlignment_Load(object sender, EventArgs e)
        {

        }
    }
}
