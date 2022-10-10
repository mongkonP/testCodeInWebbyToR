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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/RemoveOneRow.htm
    public partial  class frmRemoveOneRow:Form
    {
        public frmRemoveOneRow()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRemoveOneRow
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRemoveOneRow";
            this.Text = "frmRemoveOneRow";
            this.Load += new System.EventHandler(this.frmRemoveOneRow_Load);
            this.ResumeLayout(false);

        }

        private void frmRemoveOneRow_Load(object sender, EventArgs e)
        {

        }
    }
}
