using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0460__virtual
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Illustratespolymorphism.htm
    public partial  class frmIllustratespolymorphism:Form
    {
        public frmIllustratespolymorphism()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmIllustratespolymorphism
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmIllustratespolymorphism";
            this.Text = "frmIllustratespolymorphism";
            this.Load += new System.EventHandler(this.frmIllustratespolymorphism_Load);
            this.ResumeLayout(false);

        }

        private void frmIllustratespolymorphism_Load(object sender, EventArgs e)
        {

        }
    }
}
