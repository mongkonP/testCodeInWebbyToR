using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0860__static_constructor
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/StaticConstructors.htm
    public partial  class frmStaticConstructors:Form
    {
        public frmStaticConstructors()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmStaticConstructors
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmStaticConstructors";
            this.Text = "frmStaticConstructors";
            this.Load += new System.EventHandler(this.frmStaticConstructors_Load);
            this.ResumeLayout(false);

        }

        private void frmStaticConstructors_Load(object sender, EventArgs e)
        {

        }
    }
}
