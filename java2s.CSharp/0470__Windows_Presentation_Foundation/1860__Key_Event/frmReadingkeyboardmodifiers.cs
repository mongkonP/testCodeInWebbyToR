using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1860__Key_Event
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Readingkeyboardmodifiers.htm
    public partial  class frmReadingkeyboardmodifiers:Form
    {
        public frmReadingkeyboardmodifiers()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReadingkeyboardmodifiers
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReadingkeyboardmodifiers";
            this.Text = "frmReadingkeyboardmodifiers";
            this.Load += new System.EventHandler(this.frmReadingkeyboardmodifiers_Load);
            this.ResumeLayout(false);

        }

        private void frmReadingkeyboardmodifiers_Load(object sender, EventArgs e)
        {

        }
    }
}
