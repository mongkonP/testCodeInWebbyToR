using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0120__struct.C0020__struct
{
    //http://www.java2s.com/Tutorial/CSharp/0120__struct/structwithvaluetypesandreftypes.htm
    public partial  class frmstructwithvaluetypesandreftypes:Form
    {
        public frmstructwithvaluetypesandreftypes()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmstructwithvaluetypesandreftypes
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmstructwithvaluetypesandreftypes";
            this.Text = "frmstructwithvaluetypesandreftypes";
            this.Load += new System.EventHandler(this.frmstructwithvaluetypesandreftypes_Load);
            this.ResumeLayout(false);

        }

        private void frmstructwithvaluetypesandreftypes_Load(object sender, EventArgs e)
        {

        }
    }
}
