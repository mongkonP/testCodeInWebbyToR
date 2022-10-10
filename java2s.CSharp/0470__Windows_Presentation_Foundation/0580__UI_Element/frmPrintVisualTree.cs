using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0580__UI_Element
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/PrintVisualTree.htm
    public partial  class frmPrintVisualTree:Form
    {
        public frmPrintVisualTree()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPrintVisualTree
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPrintVisualTree";
            this.Text = "frmPrintVisualTree";
            this.Load += new System.EventHandler(this.frmPrintVisualTree_Load);
            this.ResumeLayout(false);

        }

        private void frmPrintVisualTree_Load(object sender, EventArgs e)
        {

        }
    }
}
