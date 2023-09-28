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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ToolTipwithListitems.htm
    public partial  class frmToolTipwithListitems:Form
    {
        public frmToolTipwithListitems()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmToolTipwithListitems
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmToolTipwithListitems";
            this.Text = "frmToolTipwithListitems";
            this.Load += new System.EventHandler(this.frmToolTipwithListitems_Load);
            this.ResumeLayout(false);

        }

        private void frmToolTipwithListitems_Load(object sender, EventArgs e)
        {

        }
    }
}
