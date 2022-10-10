using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0940__ColorDialog
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/ColorDialogFullOpentrue.htm
    public partial  class frmColorDialogFullOpentrue:Form
    {
        public frmColorDialogFullOpentrue()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmColorDialogFullOpentrue
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmColorDialogFullOpentrue";
            this.Text = "frmColorDialogFullOpentrue";
            this.Load += new System.EventHandler(this.frmColorDialogFullOpentrue_Load);
            this.ResumeLayout(false);

        }

        private void frmColorDialogFullOpentrue_Load(object sender, EventArgs e)
        {

        }
    }
}
