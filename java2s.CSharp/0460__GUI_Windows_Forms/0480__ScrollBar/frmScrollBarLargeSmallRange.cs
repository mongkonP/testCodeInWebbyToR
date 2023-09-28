using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0480__ScrollBar
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/ScrollBarLargeSmallRange.htm
    public partial  class frmScrollBarLargeSmallRange:Form
    {
        public frmScrollBarLargeSmallRange()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmScrollBarLargeSmallRange
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmScrollBarLargeSmallRange";
            this.Text = "frmScrollBarLargeSmallRange";
            this.Load += new System.EventHandler(this.frmScrollBarLargeSmallRange_Load);
            this.ResumeLayout(false);

        }

        private void frmScrollBarLargeSmallRange_Load(object sender, EventArgs e)
        {

        }
    }
}
