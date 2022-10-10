using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0440__I18N_Internationalization.C0100__CultureAndRegionInfoBuilder
{
    //http://www.java2s.com/Tutorial/CSharp/0440__I18N-Internationalization/CultureAndRegionInformationBuilder.htm
    public partial  class frmCultureAndRegionInformationBuilder:Form
    {
        public frmCultureAndRegionInformationBuilder()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCultureAndRegionInformationBuilder
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCultureAndRegionInformationBuilder";
            this.Text = "frmCultureAndRegionInformationBuilder";
            this.Load += new System.EventHandler(this.frmCultureAndRegionInformationBuilder_Load);
            this.ResumeLayout(false);

        }

        private void frmCultureAndRegionInformationBuilder_Load(object sender, EventArgs e)
        {

        }
    }
}
