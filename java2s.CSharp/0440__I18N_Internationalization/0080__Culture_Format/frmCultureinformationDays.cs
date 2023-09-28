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
    //http://www.java2s.com/Tutorial/CSharp/0440__I18N-Internationalization/CultureinformationDays.htm
    public partial  class frmCultureinformationDays:Form
    {
        public frmCultureinformationDays()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCultureinformationDays
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCultureinformationDays";
            this.Text = "frmCultureinformationDays";
            this.Load += new System.EventHandler(this.frmCultureinformationDays_Load);
            this.ResumeLayout(false);

        }

        private void frmCultureinformationDays_Load(object sender, EventArgs e)
        {

        }
    }
}
