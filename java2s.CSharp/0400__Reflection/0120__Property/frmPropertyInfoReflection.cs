using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0400__Reflection.C0120__Property
{
    //http://www.java2s.com/Tutorial/CSharp/0400__Reflection/PropertyInfoReflection.htm
    public partial  class frmPropertyInfoReflection:Form
    {
        public frmPropertyInfoReflection()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPropertyInfoReflection
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPropertyInfoReflection";
            this.Text = "frmPropertyInfoReflection";
            this.Load += new System.EventHandler(this.frmPropertyInfoReflection_Load);
            this.ResumeLayout(false);

        }

        private void frmPropertyInfoReflection_Load(object sender, EventArgs e)
        {

        }
    }
}
