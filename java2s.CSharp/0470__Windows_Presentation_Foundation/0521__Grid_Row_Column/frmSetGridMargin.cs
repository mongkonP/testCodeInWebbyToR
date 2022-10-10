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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/SetGridMargin.htm
    public partial  class frmSetGridMargin:Form
    {
        public frmSetGridMargin()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSetGridMargin
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSetGridMargin";
            this.Text = "frmSetGridMargin";
            this.Load += new System.EventHandler(this.frmSetGridMargin_Load);
            this.ResumeLayout(false);

        }

        private void frmSetGridMargin_Load(object sender, EventArgs e)
        {

        }
    }
}
