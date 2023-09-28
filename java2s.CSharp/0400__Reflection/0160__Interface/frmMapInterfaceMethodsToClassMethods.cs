using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0400__Reflection.C0160__Interface
{
    //http://www.java2s.com/Tutorial/CSharp/0400__Reflection/MapInterfaceMethodsToClassMethods.htm
    public partial  class frmMapInterfaceMethodsToClassMethods:Form
    {
        public frmMapInterfaceMethodsToClassMethods()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMapInterfaceMethodsToClassMethods
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmMapInterfaceMethodsToClassMethods";
            this.Text = "frmMapInterfaceMethodsToClassMethods";
            this.Load += new System.EventHandler(this.frmMapInterfaceMethodsToClassMethods_Load);
            this.ResumeLayout(false);

        }

        private void frmMapInterfaceMethodsToClassMethods_Load(object sender, EventArgs e)
        {

        }
    }
}
