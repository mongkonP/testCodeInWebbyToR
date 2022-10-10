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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/RichTextBoxbasedTextEditor.htm
    public partial  class frmRichTextBoxbasedTextEditor:Form
    {
        public frmRichTextBoxbasedTextEditor()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRichTextBoxbasedTextEditor
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRichTextBoxbasedTextEditor";
            this.Text = "frmRichTextBoxbasedTextEditor";
            this.Load += new System.EventHandler(this.frmRichTextBoxbasedTextEditor_Load);
            this.ResumeLayout(false);

        }

        private void frmRichTextBoxbasedTextEditor_Load(object sender, EventArgs e)
        {

        }
    }
}
