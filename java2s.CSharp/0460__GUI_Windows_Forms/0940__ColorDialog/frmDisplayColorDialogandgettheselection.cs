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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/DisplayColorDialogandgettheselection.htm
    public partial  class frmDisplayColorDialogandgettheselection:Form
    {
        public frmDisplayColorDialogandgettheselection()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDisplayColorDialogandgettheselection
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDisplayColorDialogandgettheselection";
            this.Text = "frmDisplayColorDialogandgettheselection";
            this.Load += new System.EventHandler(this.frmDisplayColorDialogandgettheselection_Load);
            this.ResumeLayout(false);

        }

        private void frmDisplayColorDialogandgettheselection_Load(object sender, EventArgs e)
        {

        }
    }
}
