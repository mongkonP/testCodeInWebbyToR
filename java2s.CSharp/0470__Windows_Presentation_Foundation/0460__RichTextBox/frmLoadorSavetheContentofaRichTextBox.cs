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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/LoadorSavetheContentofaRichTextBox.htm
    public partial  class frmLoadorSavetheContentofaRichTextBox:Form
    {
        public frmLoadorSavetheContentofaRichTextBox()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmLoadorSavetheContentofaRichTextBox
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmLoadorSavetheContentofaRichTextBox";
            this.Text = "frmLoadorSavetheContentofaRichTextBox";
            this.Load += new System.EventHandler(this.frmLoadorSavetheContentofaRichTextBox_Load);
            this.ResumeLayout(false);

        }

        private void frmLoadorSavetheContentofaRichTextBox_Load(object sender, EventArgs e)
        {

        }
    }
}
