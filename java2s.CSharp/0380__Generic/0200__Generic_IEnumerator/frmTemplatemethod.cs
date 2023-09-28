using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0380__Generic.C0200__Generic_IEnumerator
{
    //http://www.java2s.com/Tutorial/CSharp/0380__Generic/Templatemethod.htm
    public partial  class frmTemplatemethod:Form
    {
        public frmTemplatemethod()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTemplatemethod
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTemplatemethod";
            this.Text = "frmTemplatemethod";
            this.Load += new System.EventHandler(this.frmTemplatemethod_Load);
            this.ResumeLayout(false);

        }

        private void frmTemplatemethod_Load(object sender, EventArgs e)
        {

        }
    }
}
