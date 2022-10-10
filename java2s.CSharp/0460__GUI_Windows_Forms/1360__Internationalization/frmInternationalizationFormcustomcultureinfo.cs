using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C1360__Internationalization
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/InternationalizationFormcustomcultureinfo.htm
    public partial  class frmInternationalizationFormcustomcultureinfo:Form
    {
        public frmInternationalizationFormcustomcultureinfo()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmInternationalizationFormcustomcultureinfo
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmInternationalizationFormcustomcultureinfo";
            this.Text = "frmInternationalizationFormcustomcultureinfo";
            this.Load += new System.EventHandler(this.frmInternationalizationFormcustomcultureinfo_Load);
            this.ResumeLayout(false);

        }

        private void frmInternationalizationFormcustomcultureinfo_Load(object sender, EventArgs e)
        {

        }
    }
}
