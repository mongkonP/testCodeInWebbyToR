using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0040__Form
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/MoveaFormincode.htm
    public partial  class frmMoveaFormincode:Form
    {
        public frmMoveaFormincode()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMoveaFormincode
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmMoveaFormincode";
            this.Text = "frmMoveaFormincode";
            this.Load += new System.EventHandler(this.frmMoveaFormincode_Load);
            this.ResumeLayout(false);

        }

        private void frmMoveaFormincode_Load(object sender, EventArgs e)
        {

        }
    }
}
