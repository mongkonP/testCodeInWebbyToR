using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0400__RichTextBox
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/EditorbasedonRichTextBox.htm
    public partial  class frmEditorbasedonRichTextBox:Form
    {
        public frmEditorbasedonRichTextBox()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmEditorbasedonRichTextBox
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmEditorbasedonRichTextBox";
            this.Text = "frmEditorbasedonRichTextBox";
            this.Load += new System.EventHandler(this.frmEditorbasedonRichTextBox_Load);
            this.ResumeLayout(false);

        }

        private void frmEditorbasedonRichTextBox_Load(object sender, EventArgs e)
        {

        }
    }
}
