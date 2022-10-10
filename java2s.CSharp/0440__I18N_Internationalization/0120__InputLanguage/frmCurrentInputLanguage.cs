using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0440__I18N_Internationalization.C0120__InputLanguage
{
    //http://www.java2s.com/Tutorial/CSharp/0440__I18N-Internationalization/CurrentInputLanguage.htm
    public partial  class frmCurrentInputLanguage:Form
    {
        public frmCurrentInputLanguage()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCurrentInputLanguage
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCurrentInputLanguage";
            this.Text = "frmCurrentInputLanguage";
            this.Load += new System.EventHandler(this.frmCurrentInputLanguage_Load);
            this.ResumeLayout(false);

        }

        private void frmCurrentInputLanguage_Load(object sender, EventArgs e)
        {

        }
    }
}
