using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0540__Abstract_Class
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/UsingAbstractClasses.htm
    public partial  class frmUsingAbstractClasses:Form
    {
        public frmUsingAbstractClasses()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingAbstractClasses
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingAbstractClasses";
            this.Text = "frmUsingAbstractClasses";
            this.Load += new System.EventHandler(this.frmUsingAbstractClasses_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingAbstractClasses_Load(object sender, EventArgs e)
        {

        }
    }
}
