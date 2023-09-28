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
    //http://www.java2s.com/Tutorial/CSharp/0400__Reflection/GetAssemblyDescriptionAttribute.htm
    public partial  class frmGetAssemblyDescriptionAttribute:Form
    {
        public frmGetAssemblyDescriptionAttribute()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetAssemblyDescriptionAttribute
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetAssemblyDescriptionAttribute";
            this.Text = "frmGetAssemblyDescriptionAttribute";
            this.Load += new System.EventHandler(this.frmGetAssemblyDescriptionAttribute_Load);
            this.ResumeLayout(false);

        }

        private void frmGetAssemblyDescriptionAttribute_Load(object sender, EventArgs e)
        {

        }
    }
}
