using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C1140__Anchoring
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/AnchorStylesBottomAnchorStylesRight.htm
    public partial  class frmAnchorStylesBottomAnchorStylesRight:Form
    {
        public frmAnchorStylesBottomAnchorStylesRight()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAnchorStylesBottomAnchorStylesRight
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAnchorStylesBottomAnchorStylesRight";
            this.Text = "frmAnchorStylesBottomAnchorStylesRight";
            this.Load += new System.EventHandler(this.frmAnchorStylesBottomAnchorStylesRight_Load);
            this.ResumeLayout(false);

        }

        private void frmAnchorStylesBottomAnchorStylesRight_Load(object sender, EventArgs e)
        {

        }
    }
}
