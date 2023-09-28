using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0400__Reflection.C0020__Type
{
    //http://www.java2s.com/Tutorial/CSharp/0400__Reflection/GetanarrayofnestedtypeobjectsinMyClass.htm
    public partial  class frmGetanarrayofnestedtypeobjectsinMyClass:Form
    {
        public frmGetanarrayofnestedtypeobjectsinMyClass()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetanarrayofnestedtypeobjectsinMyClass
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetanarrayofnestedtypeobjectsinMyClass";
            this.Text = "frmGetanarrayofnestedtypeobjectsinMyClass";
            this.Load += new System.EventHandler(this.frmGetanarrayofnestedtypeobjectsinMyClass_Load);
            this.ResumeLayout(false);

        }

        private void frmGetanarrayofnestedtypeobjectsinMyClass_Load(object sender, EventArgs e)
        {

        }
    }
}
