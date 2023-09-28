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
    //http://www.java2s.com/Tutorial/CSharp/0400__Reflection/ReflectingOnAType.htm
    public partial  class frmReflectingOnAType:Form
    {
        public frmReflectingOnAType()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReflectingOnAType
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReflectingOnAType";
            this.Text = "frmReflectingOnAType";
            this.Load += new System.EventHandler(this.frmReflectingOnAType_Load);
            this.ResumeLayout(false);

        }

        private void frmReflectingOnAType_Load(object sender, EventArgs e)
        {

        }
    }
}
