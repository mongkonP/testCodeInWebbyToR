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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/FontDialogDisplayandgetselectedfont.htm
    public partial  class frmFontDialogDisplayandgetselectedfont:Form
    {
        public frmFontDialogDisplayandgetselectedfont()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFontDialogDisplayandgetselectedfont
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFontDialogDisplayandgetselectedfont";
            this.Text = "frmFontDialogDisplayandgetselectedfont";
            this.Load += new System.EventHandler(this.frmFontDialogDisplayandgetselectedfont_Load);
            this.ResumeLayout(false);

        }

        private void frmFontDialogDisplayandgetselectedfont_Load(object sender, EventArgs e)
        {

        }
    }
}
