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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/InsertColumn.htm
    public partial  class frmInsertColumn:Form
    {
        public frmInsertColumn()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmInsertColumn
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmInsertColumn";
            this.Text = "frmInsertColumn";
            this.Load += new System.EventHandler(this.frmInsertColumn_Load);
            this.ResumeLayout(false);

        }

        private void frmInsertColumn_Load(object sender, EventArgs e)
        {

        }
    }
}
