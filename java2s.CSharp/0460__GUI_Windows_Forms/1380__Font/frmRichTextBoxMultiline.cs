using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C1380__Font
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/RichTextBoxMultiline.htm
    public partial  class frmRichTextBoxMultiline:Form
    {
        public frmRichTextBoxMultiline()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRichTextBoxMultiline
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRichTextBoxMultiline";
            this.Text = "frmRichTextBoxMultiline";
            this.Load += new System.EventHandler(this.frmRichTextBoxMultiline_Load);
            this.ResumeLayout(false);

        }

        private void frmRichTextBoxMultiline_Load(object sender, EventArgs e)
        {

        }
    }
}
