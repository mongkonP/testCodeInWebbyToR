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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/AddBordertoTextBlock.htm
    public partial  class frmAddBordertoTextBlock:Form
    {
        public frmAddBordertoTextBlock()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddBordertoTextBlock
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddBordertoTextBlock";
            this.Text = "frmAddBordertoTextBlock";
            this.Load += new System.EventHandler(this.frmAddBordertoTextBlock_Load);
            this.ResumeLayout(false);

        }

        private void frmAddBordertoTextBlock_Load(object sender, EventArgs e)
        {

        }
    }
}
