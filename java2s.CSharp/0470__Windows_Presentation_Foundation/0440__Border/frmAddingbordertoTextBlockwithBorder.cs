using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0440__Border
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/AddingbordertoTextBlockwithBorder.htm
    public partial  class frmAddingbordertoTextBlockwithBorder:Form
    {
        public frmAddingbordertoTextBlockwithBorder()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddingbordertoTextBlockwithBorder
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddingbordertoTextBlockwithBorder";
            this.Text = "frmAddingbordertoTextBlockwithBorder";
            this.Load += new System.EventHandler(this.frmAddingbordertoTextBlockwithBorder_Load);
            this.ResumeLayout(false);

        }

        private void frmAddingbordertoTextBlockwithBorder_Load(object sender, EventArgs e)
        {

        }
    }
}
