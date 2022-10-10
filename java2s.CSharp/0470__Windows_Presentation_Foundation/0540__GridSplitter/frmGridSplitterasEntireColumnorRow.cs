using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0540__GridSplitter
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/GridSplitterasEntireColumnorRow.htm
    public partial  class frmGridSplitterasEntireColumnorRow:Form
    {
        public frmGridSplitterasEntireColumnorRow()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGridSplitterasEntireColumnorRow
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGridSplitterasEntireColumnorRow";
            this.Text = "frmGridSplitterasEntireColumnorRow";
            this.Load += new System.EventHandler(this.frmGridSplitterasEntireColumnorRow_Load);
            this.ResumeLayout(false);

        }

        private void frmGridSplitterasEntireColumnorRow_Load(object sender, EventArgs e)
        {

        }
    }
}
