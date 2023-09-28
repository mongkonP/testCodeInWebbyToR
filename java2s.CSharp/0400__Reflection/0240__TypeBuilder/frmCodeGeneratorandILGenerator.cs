using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0400__Reflection.C0240__TypeBuilder
{
    //http://www.java2s.com/Tutorial/CSharp/0400__Reflection/CodeGeneratorandILGenerator.htm
    public partial  class frmCodeGeneratorandILGenerator:Form
    {
        public frmCodeGeneratorandILGenerator()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCodeGeneratorandILGenerator
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCodeGeneratorandILGenerator";
            this.Text = "frmCodeGeneratorandILGenerator";
            this.Load += new System.EventHandler(this.frmCodeGeneratorandILGenerator_Load);
            this.ResumeLayout(false);

        }

        private void frmCodeGeneratorandILGenerator_Load(object sender, EventArgs e)
        {

        }
    }
}
