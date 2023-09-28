using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0040__Data_Type.C0100__int_Box_Unbox
{
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/implicitboxingfromitoobject.htm
    public partial  class frmimplicitboxingfromitoobject:Form
    {
        public frmimplicitboxingfromitoobject()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmimplicitboxingfromitoobject
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmimplicitboxingfromitoobject";
            this.Text = "frmimplicitboxingfromitoobject";
            this.Load += new System.EventHandler(this.frmimplicitboxingfromitoobject_Load);
            this.ResumeLayout(false);

        }

        private void frmimplicitboxingfromitoobject_Load(object sender, EventArgs e)
        {

        }
    }
}
