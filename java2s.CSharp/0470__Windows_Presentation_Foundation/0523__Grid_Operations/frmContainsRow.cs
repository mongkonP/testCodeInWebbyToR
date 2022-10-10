using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0523__Grid_Operations
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ContainsRow.htm
    public partial  class frmContainsRow:Form
    {
        public frmContainsRow()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmContainsRow
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmContainsRow";
            this.Text = "frmContainsRow";
            this.Load += new System.EventHandler(this.frmContainsRow_Load);
            this.ResumeLayout(false);

        }

        private void frmContainsRow_Load(object sender, EventArgs e)
        {

        }
    }
}
