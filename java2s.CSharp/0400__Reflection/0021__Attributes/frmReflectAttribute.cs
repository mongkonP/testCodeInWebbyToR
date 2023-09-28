using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0400__Reflection.C0021__Attributes
{
    //http://www.java2s.com/Tutorial/CSharp/0400__Reflection/ReflectAttribute.htm
    public partial  class frmReflectAttribute:Form
    {
        public frmReflectAttribute()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReflectAttribute
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReflectAttribute";
            this.Text = "frmReflectAttribute";
            this.Load += new System.EventHandler(this.frmReflectAttribute_Load);
            this.ResumeLayout(false);

        }

        private void frmReflectAttribute_Load(object sender, EventArgs e)
        {

        }
    }
}
