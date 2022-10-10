using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0440__I18N_Internationalization.C0140__Number_Parse
{
    //http://www.java2s.com/Tutorial/CSharp/0440__I18N-Internationalization/ParsingnumbersbasedonCultureinfo.htm
    public partial  class frmParsingnumbersbasedonCultureinfo:Form
    {
        public frmParsingnumbersbasedonCultureinfo()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmParsingnumbersbasedonCultureinfo
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmParsingnumbersbasedonCultureinfo";
            this.Text = "frmParsingnumbersbasedonCultureinfo";
            this.Load += new System.EventHandler(this.frmParsingnumbersbasedonCultureinfo_Load);
            this.ResumeLayout(false);

        }

        private void frmParsingnumbersbasedonCultureinfo_Load(object sender, EventArgs e)
        {

        }
    }
}
