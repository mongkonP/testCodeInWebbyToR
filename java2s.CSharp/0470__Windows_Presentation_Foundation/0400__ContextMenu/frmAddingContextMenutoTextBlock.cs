using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0400__ContextMenu
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/AddingContextMenutoTextBlock.htm
    public partial  class frmAddingContextMenutoTextBlock:Form
    {
        public frmAddingContextMenutoTextBlock()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddingContextMenutoTextBlock
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddingContextMenutoTextBlock";
            this.Text = "frmAddingContextMenutoTextBlock";
            this.Load += new System.EventHandler(this.frmAddingContextMenutoTextBlock_Load);
            this.ResumeLayout(false);

        }

        private void frmAddingContextMenutoTextBlock_Load(object sender, EventArgs e)
        {

        }
    }
}
