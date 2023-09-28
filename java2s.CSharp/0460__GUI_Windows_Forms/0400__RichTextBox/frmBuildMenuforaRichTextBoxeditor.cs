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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/BuildMenuforaRichTextBoxeditor.htm
    public partial  class frmBuildMenuforaRichTextBoxeditor:Form
    {
        public frmBuildMenuforaRichTextBoxeditor()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmBuildMenuforaRichTextBoxeditor
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmBuildMenuforaRichTextBoxeditor";
            this.Text = "frmBuildMenuforaRichTextBoxeditor";
            this.Load += new System.EventHandler(this.frmBuildMenuforaRichTextBoxeditor_Load);
            this.ResumeLayout(false);

        }

        private void frmBuildMenuforaRichTextBoxeditor_Load(object sender, EventArgs e)
        {

        }
    }
}
