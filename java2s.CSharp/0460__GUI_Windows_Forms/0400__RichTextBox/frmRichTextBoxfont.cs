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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/RichTextBoxfont.htm
    public partial  class frmRichTextBoxfont:Form
    {
        public frmRichTextBoxfont()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRichTextBoxfont
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRichTextBoxfont";
            this.Text = "frmRichTextBoxfont";
            this.Load += new System.EventHandler(this.frmRichTextBoxfont_Load);
            this.ResumeLayout(false);

        }

        private void frmRichTextBoxfont_Load(object sender, EventArgs e)
        {

        }
    }
}
