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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/AddRemoveTextChangedeventforRichTextBox.htm
    public partial  class frmAddRemoveTextChangedeventforRichTextBox:Form
    {
        public frmAddRemoveTextChangedeventforRichTextBox()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddRemoveTextChangedeventforRichTextBox
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddRemoveTextChangedeventforRichTextBox";
            this.Text = "frmAddRemoveTextChangedeventforRichTextBox";
            this.Load += new System.EventHandler(this.frmAddRemoveTextChangedeventforRichTextBox_Load);
            this.ResumeLayout(false);

        }

        private void frmAddRemoveTextChangedeventforRichTextBox_Load(object sender, EventArgs e)
        {

        }
    }
}
