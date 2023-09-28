using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2200__ItemsControl
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/SortDatainaCollection.htm
    public partial  class frmSortDatainaCollection:Form
    {
        public frmSortDatainaCollection()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSortDatainaCollection
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSortDatainaCollection";
            this.Text = "frmSortDatainaCollection";
            this.Load += new System.EventHandler(this.frmSortDatainaCollection_Load);
            this.ResumeLayout(false);

        }

        private void frmSortDatainaCollection_Load(object sender, EventArgs e)
        {

        }
    }
}
