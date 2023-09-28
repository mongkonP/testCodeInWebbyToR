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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/FontDialogsetcolorApplyevent.htm
    public partial  class frmFontDialogsetcolorApplyevent:Form
    {
        public frmFontDialogsetcolorApplyevent()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFontDialogsetcolorApplyevent
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFontDialogsetcolorApplyevent";
            this.Text = "frmFontDialogsetcolorApplyevent";
            this.Load += new System.EventHandler(this.frmFontDialogsetcolorApplyevent_Load);
            this.ResumeLayout(false);

        }

        private void frmFontDialogsetcolorApplyevent_Load(object sender, EventArgs e)
        {

        }
    }
}
