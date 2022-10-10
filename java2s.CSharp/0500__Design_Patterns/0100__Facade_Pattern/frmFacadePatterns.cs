using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0500__Design_Patterns.C0100__Facade_Pattern
{
    //http://www.java2s.com/Tutorial/CSharp/0500__Design-Patterns/FacadePatterns.htm
    public partial  class frmFacadePatterns:Form
    {
        public frmFacadePatterns()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFacadePatterns
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFacadePatterns";
            this.Text = "frmFacadePatterns";
            this.Load += new System.EventHandler(this.frmFacadePatterns_Load);
            this.ResumeLayout(false);

        }

        private void frmFacadePatterns_Load(object sender, EventArgs e)
        {

        }
    }
}
