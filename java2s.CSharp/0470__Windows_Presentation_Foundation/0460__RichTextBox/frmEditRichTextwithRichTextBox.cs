using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0460__RichTextBox
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/EditRichTextwithRichTextBox.htm
    public partial  class frmEditRichTextwithRichTextBox:Form
    {
        public frmEditRichTextwithRichTextBox()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmEditRichTextwithRichTextBox
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmEditRichTextwithRichTextBox";
            this.Text = "frmEditRichTextwithRichTextBox";
            this.Load += new System.EventHandler(this.frmEditRichTextwithRichTextBox_Load);
            this.ResumeLayout(false);

        }

        private void frmEditRichTextwithRichTextBox_Load(object sender, EventArgs e)
        {

        }
    }
}
