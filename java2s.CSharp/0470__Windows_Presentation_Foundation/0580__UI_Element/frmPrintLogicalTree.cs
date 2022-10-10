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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/PrintLogicalTree.htm
    public partial  class frmPrintLogicalTree:Form
    {
        public frmPrintLogicalTree()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPrintLogicalTree
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPrintLogicalTree";
            this.Text = "frmPrintLogicalTree";
            this.Load += new System.EventHandler(this.frmPrintLogicalTree_Load);
            this.ResumeLayout(false);

        }

        private void frmPrintLogicalTree_Load(object sender, EventArgs e)
        {

        }
    }
}
