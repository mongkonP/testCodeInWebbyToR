using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0960__FontDialog
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/FontDialogApplyevent.htm
    public partial  class frmFontDialogApplyevent:Form
    {
        public frmFontDialogApplyevent()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFontDialogApplyevent
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFontDialogApplyevent";
            this.Text = "frmFontDialogApplyevent";
            this.Load += new System.EventHandler(this.frmFontDialogApplyevent_Load);
            this.ResumeLayout(false);

        }

        private void frmFontDialogApplyevent_Load(object sender, EventArgs e)
        {

        }
    }
}
