using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0080__Form_Paint
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/PaintInvalidateDemonstration.htm
    public partial  class frmPaintInvalidateDemonstration:Form
    {
        public frmPaintInvalidateDemonstration()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPaintInvalidateDemonstration
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPaintInvalidateDemonstration";
            this.Text = "frmPaintInvalidateDemonstration";
            this.Load += new System.EventHandler(this.frmPaintInvalidateDemonstration_Load);
            this.ResumeLayout(false);

        }

        private void frmPaintInvalidateDemonstration_Load(object sender, EventArgs e)
        {

        }
    }
}
