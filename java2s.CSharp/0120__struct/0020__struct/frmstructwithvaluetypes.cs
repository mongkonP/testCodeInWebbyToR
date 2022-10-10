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
    //http://www.java2s.com/Tutorial/CSharp/0120__struct/structwithvaluetypes.htm
    public partial  class frmstructwithvaluetypes:Form
    {
        public frmstructwithvaluetypes()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmstructwithvaluetypes
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmstructwithvaluetypes";
            this.Text = "frmstructwithvaluetypes";
            this.Load += new System.EventHandler(this.frmstructwithvaluetypes_Load);
            this.ResumeLayout(false);

        }

        private void frmstructwithvaluetypes_Load(object sender, EventArgs e)
        {

        }
    }
}
