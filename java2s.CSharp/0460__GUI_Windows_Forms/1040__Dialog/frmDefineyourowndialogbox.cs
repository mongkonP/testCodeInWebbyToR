using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C1040__Dialog
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/Defineyourowndialogbox.htm
    public partial  class frmDefineyourowndialogbox:Form
    {
        public frmDefineyourowndialogbox()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDefineyourowndialogbox
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDefineyourowndialogbox";
            this.Text = "frmDefineyourowndialogbox";
            this.Load += new System.EventHandler(this.frmDefineyourowndialogbox_Load);
            this.ResumeLayout(false);

        }

        private void frmDefineyourowndialogbox_Load(object sender, EventArgs e)
        {

        }
    }
}
