using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0440__I18N_Internationalization.C0080__Culture_Format
{
    //http://www.java2s.com/Tutorial/CSharp/0440__I18N-Internationalization/CultureinformationMonths.htm
    public partial  class frmCultureinformationMonths:Form
    {
        public frmCultureinformationMonths()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCultureinformationMonths
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCultureinformationMonths";
            this.Text = "frmCultureinformationMonths";
            this.Load += new System.EventHandler(this.frmCultureinformationMonths_Load);
            this.ResumeLayout(false);

        }

        private void frmCultureinformationMonths_Load(object sender, EventArgs e)
        {

        }
    }
}
