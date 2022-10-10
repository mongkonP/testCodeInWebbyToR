using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0440__I18N_Internationalization.C0020__CultureInfo
{
    //http://www.java2s.com/Tutorial/CSharp/0440__I18N-Internationalization/turkishiproblem.htm
    public partial  class frmturkishiproblem:Form
    {
        public frmturkishiproblem()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmturkishiproblem
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmturkishiproblem";
            this.Text = "frmturkishiproblem";
            this.Load += new System.EventHandler(this.frmturkishiproblem_Load);
            this.ResumeLayout(false);

        }

        private void frmturkishiproblem_Load(object sender, EventArgs e)
        {

        }
    }
}
