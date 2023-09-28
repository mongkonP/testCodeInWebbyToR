using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0680__Explicit_Interface_Implementation
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Useexplicitimplementationtoremoveambiguity.htm
    public partial  class frmUseexplicitimplementationtoremoveambiguity:Form
    {
        public frmUseexplicitimplementationtoremoveambiguity()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseexplicitimplementationtoremoveambiguity
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseexplicitimplementationtoremoveambiguity";
            this.Text = "frmUseexplicitimplementationtoremoveambiguity";
            this.Load += new System.EventHandler(this.frmUseexplicitimplementationtoremoveambiguity_Load);
            this.ResumeLayout(false);

        }

        private void frmUseexplicitimplementationtoremoveambiguity_Load(object sender, EventArgs e)
        {

        }
    }
}
