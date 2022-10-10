using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0440__I18N_Internationalization.C0061__CompareInfo
{
    //http://www.java2s.com/Tutorial/CSharp/0440__I18N-Internationalization/CompareInfofromCultureInfo.htm
    public partial  class frmCompareInfofromCultureInfo:Form
    {
        public frmCompareInfofromCultureInfo()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCompareInfofromCultureInfo
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCompareInfofromCultureInfo";
            this.Text = "frmCompareInfofromCultureInfo";
            this.Load += new System.EventHandler(this.frmCompareInfofromCultureInfo_Load);
            this.ResumeLayout(false);

        }

        private void frmCompareInfofromCultureInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
