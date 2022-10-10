using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0160__Method_Overload
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Overloadedconstructors.htm
    public partial  class frmOverloadedconstructors:Form
    {
        public frmOverloadedconstructors()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmOverloadedconstructors
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmOverloadedconstructors";
            this.Text = "frmOverloadedconstructors";
            this.Load += new System.EventHandler(this.frmOverloadedconstructors_Load);
            this.ResumeLayout(false);

        }

        private void frmOverloadedconstructors_Load(object sender, EventArgs e)
        {

        }
    }
}
