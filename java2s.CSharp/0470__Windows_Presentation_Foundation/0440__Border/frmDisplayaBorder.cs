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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/DisplayaBorder.htm
    public partial  class frmDisplayaBorder:Form
    {
        public frmDisplayaBorder()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDisplayaBorder
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDisplayaBorder";
            this.Text = "frmDisplayaBorder";
            this.Load += new System.EventHandler(this.frmDisplayaBorder_Load);
            this.ResumeLayout(false);

        }

        private void frmDisplayaBorder_Load(object sender, EventArgs e)
        {

        }
    }
}
