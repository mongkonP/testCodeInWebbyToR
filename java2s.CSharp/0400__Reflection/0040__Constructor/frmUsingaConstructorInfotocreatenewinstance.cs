using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0400__Reflection.C0040__Constructor
{
    //http://www.java2s.com/Tutorial/CSharp/0400__Reflection/UsingaConstructorInfotocreatenewinstance.htm
    public partial  class frmUsingaConstructorInfotocreatenewinstance:Form
    {
        public frmUsingaConstructorInfotocreatenewinstance()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingaConstructorInfotocreatenewinstance
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingaConstructorInfotocreatenewinstance";
            this.Text = "frmUsingaConstructorInfotocreatenewinstance";
            this.Load += new System.EventHandler(this.frmUsingaConstructorInfotocreatenewinstance_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingaConstructorInfotocreatenewinstance_Load(object sender, EventArgs e)
        {

        }
    }
}
