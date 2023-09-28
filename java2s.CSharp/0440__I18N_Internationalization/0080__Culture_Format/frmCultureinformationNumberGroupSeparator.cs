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
    //http://www.java2s.com/Tutorial/CSharp/0440__I18N-Internationalization/CultureinformationNumberGroupSeparator.htm
    public partial  class frmCultureinformationNumberGroupSeparator:Form
    {
        public frmCultureinformationNumberGroupSeparator()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCultureinformationNumberGroupSeparator
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCultureinformationNumberGroupSeparator";
            this.Text = "frmCultureinformationNumberGroupSeparator";
            this.Load += new System.EventHandler(this.frmCultureinformationNumberGroupSeparator_Load);
            this.ResumeLayout(false);

        }

        private void frmCultureinformationNumberGroupSeparator_Load(object sender, EventArgs e)
        {

        }
    }
}
