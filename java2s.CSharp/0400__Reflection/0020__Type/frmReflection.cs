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
    //http://www.java2s.com/Tutorial/CSharp/0400__Reflection/Reflection.htm
    public partial  class frmReflection:Form
    {
        public frmReflection()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReflection
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReflection";
            this.Text = "frmReflection";
            this.Load += new System.EventHandler(this.frmReflection_Load);
            this.ResumeLayout(false);

        }

        private void frmReflection_Load(object sender, EventArgs e)
        {

        }
    }
}
