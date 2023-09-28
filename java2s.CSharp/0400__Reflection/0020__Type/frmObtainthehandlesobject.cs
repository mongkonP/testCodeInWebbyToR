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
    //http://www.java2s.com/Tutorial/CSharp/0400__Reflection/Obtainthehandlesobject.htm
    public partial  class frmObtainthehandlesobject:Form
    {
        public frmObtainthehandlesobject()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmObtainthehandlesobject
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmObtainthehandlesobject";
            this.Text = "frmObtainthehandlesobject";
            this.Load += new System.EventHandler(this.frmObtainthehandlesobject_Load);
            this.ResumeLayout(false);

        }

        private void frmObtainthehandlesobject_Load(object sender, EventArgs e)
        {

        }
    }
}
