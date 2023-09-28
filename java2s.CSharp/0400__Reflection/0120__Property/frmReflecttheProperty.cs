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
    //http://www.java2s.com/Tutorial/CSharp/0400__Reflection/ReflecttheProperty.htm
    public partial  class frmReflecttheProperty:Form
    {
        public frmReflecttheProperty()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReflecttheProperty
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReflecttheProperty";
            this.Text = "frmReflecttheProperty";
            this.Load += new System.EventHandler(this.frmReflecttheProperty_Load);
            this.ResumeLayout(false);

        }

        private void frmReflecttheProperty_Load(object sender, EventArgs e)
        {

        }
    }
}
