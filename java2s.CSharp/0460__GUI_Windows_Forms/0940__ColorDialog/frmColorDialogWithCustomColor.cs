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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/ColorDialogWithCustomColor.htm
    public partial  class frmColorDialogWithCustomColor:Form
    {
        public frmColorDialogWithCustomColor()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmColorDialogWithCustomColor
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmColorDialogWithCustomColor";
            this.Text = "frmColorDialogWithCustomColor";
            this.Load += new System.EventHandler(this.frmColorDialogWithCustomColor_Load);
            this.ResumeLayout(false);

        }

        private void frmColorDialogWithCustomColor_Load(object sender, EventArgs e)
        {

        }
    }
}
