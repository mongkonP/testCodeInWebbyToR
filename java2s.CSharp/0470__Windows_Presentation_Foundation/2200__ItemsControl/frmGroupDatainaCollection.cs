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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/GroupDatainaCollection.htm
    public partial  class frmGroupDatainaCollection:Form
    {
        public frmGroupDatainaCollection()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGroupDatainaCollection
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGroupDatainaCollection";
            this.Text = "frmGroupDatainaCollection";
            this.Load += new System.EventHandler(this.frmGroupDatainaCollection_Load);
            this.ResumeLayout(false);

        }

        private void frmGroupDatainaCollection_Load(object sender, EventArgs e)
        {

        }
    }
}
