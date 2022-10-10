using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0780__Menu
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/MenuRightToLeft.htm
    public partial  class frmMenuRightToLeft:Form
    {
        public frmMenuRightToLeft()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMenuRightToLeft
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmMenuRightToLeft";
            this.Text = "frmMenuRightToLeft";
            this.Load += new System.EventHandler(this.frmMenuRightToLeft_Load);
            this.ResumeLayout(false);

        }

        private void frmMenuRightToLeft_Load(object sender, EventArgs e)
        {

        }
    }
}
