using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0521__Grid_Row_Column
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/BindtoGridWidthandHeight.htm
    public partial  class frmBindtoGridWidthandHeight:Form
    {
        public frmBindtoGridWidthandHeight()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmBindtoGridWidthandHeight
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmBindtoGridWidthandHeight";
            this.Text = "frmBindtoGridWidthandHeight";
            this.Load += new System.EventHandler(this.frmBindtoGridWidthandHeight_Load);
            this.ResumeLayout(false);

        }

        private void frmBindtoGridWidthandHeight_Load(object sender, EventArgs e)
        {

        }
    }
}
