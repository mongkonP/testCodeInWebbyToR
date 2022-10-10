using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0440__I18N_Internationalization.C0060__RegionInfo
{
    //http://www.java2s.com/Tutorial/CSharp/0440__I18N-Internationalization/CreateRegionInfoobject.htm
    public partial  class frmCreateRegionInfoobject:Form
    {
        public frmCreateRegionInfoobject()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreateRegionInfoobject
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreateRegionInfoobject";
            this.Text = "frmCreateRegionInfoobject";
            this.Load += new System.EventHandler(this.frmCreateRegionInfoobject_Load);
            this.ResumeLayout(false);

        }

        private void frmCreateRegionInfoobject_Load(object sender, EventArgs e)
        {

        }
    }
}
