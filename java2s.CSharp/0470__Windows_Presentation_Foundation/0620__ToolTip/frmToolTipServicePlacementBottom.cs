using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0620__ToolTip
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ToolTipServicePlacementBottom.htm
    public partial  class frmToolTipServicePlacementBottom:Form
    {
        public frmToolTipServicePlacementBottom()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmToolTipServicePlacementBottom
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmToolTipServicePlacementBottom";
            this.Text = "frmToolTipServicePlacementBottom";
            this.Load += new System.EventHandler(this.frmToolTipServicePlacementBottom_Load);
            this.ResumeLayout(false);

        }

        private void frmToolTipServicePlacementBottom_Load(object sender, EventArgs e)
        {

        }
    }
}
