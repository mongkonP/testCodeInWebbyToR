using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0100__TextRange
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/LoadTextRangefromFilestream.htm
    public partial  class frmLoadTextRangefromFilestream:Form
    {
        public frmLoadTextRangefromFilestream()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmLoadTextRangefromFilestream
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmLoadTextRangefromFilestream";
            this.Text = "frmLoadTextRangefromFilestream";
            this.Load += new System.EventHandler(this.frmLoadTextRangefromFilestream_Load);
            this.ResumeLayout(false);

        }

        private void frmLoadTextRangefromFilestream_Load(object sender, EventArgs e)
        {

        }
    }
}
