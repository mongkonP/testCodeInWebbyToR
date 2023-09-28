using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0400__Reflection.C0180__Generic_Type
{
    //http://www.java2s.com/Tutorial/CSharp/0400__Reflection/ReflectionwithGenerics.htm
    public partial  class frmReflectionwithGenerics:Form
    {
        public frmReflectionwithGenerics()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReflectionwithGenerics
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReflectionwithGenerics";
            this.Text = "frmReflectionwithGenerics";
            this.Load += new System.EventHandler(this.frmReflectionwithGenerics_Load);
            this.ResumeLayout(false);

        }

        private void frmReflectionwithGenerics_Load(object sender, EventArgs e)
        {

        }
    }
}
