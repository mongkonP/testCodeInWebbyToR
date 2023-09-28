using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0400__Reflection.C0220__Assembly
{
    //http://www.java2s.com/Tutorial/CSharp/0400__Reflection/ReflectingAnAssembly.htm
    public partial  class frmReflectingAnAssembly:Form
    {
        public frmReflectingAnAssembly()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReflectingAnAssembly
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReflectingAnAssembly";
            this.Text = "frmReflectingAnAssembly";
            this.Load += new System.EventHandler(this.frmReflectingAnAssembly_Load);
            this.ResumeLayout(false);

        }

        private void frmReflectingAnAssembly_Load(object sender, EventArgs e)
        {

        }
    }
}
