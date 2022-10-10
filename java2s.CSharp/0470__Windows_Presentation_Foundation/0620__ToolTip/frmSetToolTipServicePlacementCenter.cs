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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/SetToolTipServicePlacementCenter.htm
    public partial  class frmSetToolTipServicePlacementCenter:Form
    {
        public frmSetToolTipServicePlacementCenter()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSetToolTipServicePlacementCenter
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSetToolTipServicePlacementCenter";
            this.Text = "frmSetToolTipServicePlacementCenter";
            this.Load += new System.EventHandler(this.frmSetToolTipServicePlacementCenter_Load);
            this.ResumeLayout(false);

        }

        private void frmSetToolTipServicePlacementCenter_Load(object sender, EventArgs e)
        {

        }
    }
}
