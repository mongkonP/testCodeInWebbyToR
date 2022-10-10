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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/InsertRow.htm
    public partial  class frmInsertRow:Form
    {
        public frmInsertRow()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmInsertRow
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmInsertRow";
            this.Text = "frmInsertRow";
            this.Load += new System.EventHandler(this.frmInsertRow_Load);
            this.ResumeLayout(false);

        }

        private void frmInsertRow_Load(object sender, EventArgs e)
        {

        }
    }
}
