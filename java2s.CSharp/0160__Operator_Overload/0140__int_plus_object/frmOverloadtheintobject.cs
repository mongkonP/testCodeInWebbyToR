using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0160__Operator_Overload.C0140__int_plus_object
{
    //http://www.java2s.com/Tutorial/CSharp/0160__Operator-Overload/Overloadtheintobject.htm
    public partial  class frmOverloadtheintobject:Form
    {
        public frmOverloadtheintobject()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmOverloadtheintobject
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmOverloadtheintobject";
            this.Text = "frmOverloadtheintobject";
            this.Load += new System.EventHandler(this.frmOverloadtheintobject_Load);
            this.ResumeLayout(false);

        }

        private void frmOverloadtheintobject_Load(object sender, EventArgs e)
        {

        }
    }
}
