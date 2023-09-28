using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0060__TextBlock
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/AddingHyperlinktoTextBlock.htm
    public partial  class frmAddingHyperlinktoTextBlock:Form
    {
        public frmAddingHyperlinktoTextBlock()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddingHyperlinktoTextBlock
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddingHyperlinktoTextBlock";
            this.Text = "frmAddingHyperlinktoTextBlock";
            this.Load += new System.EventHandler(this.frmAddingHyperlinktoTextBlock_Load);
            this.ResumeLayout(false);

        }

        private void frmAddingHyperlinktoTextBlock_Load(object sender, EventArgs e)
        {

        }
    }
}
