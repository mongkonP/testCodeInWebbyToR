using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0520__Grid
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/MultipleItemsinaGridCell.htm
    public partial  class frmMultipleItemsinaGridCell:Form
    {
        public frmMultipleItemsinaGridCell()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMultipleItemsinaGridCell
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmMultipleItemsinaGridCell";
            this.Text = "frmMultipleItemsinaGridCell";
            this.Load += new System.EventHandler(this.frmMultipleItemsinaGridCell_Load);
            this.ResumeLayout(false);

        }

        private void frmMultipleItemsinaGridCell_Load(object sender, EventArgs e)
        {

        }
    }
}
