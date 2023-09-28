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
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/IntegerAutobox.htm
    public partial  class frmIntegerAutobox:Form
    {
        public frmIntegerAutobox()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmIntegerAutobox
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmIntegerAutobox";
            this.Text = "frmIntegerAutobox";
            this.Load += new System.EventHandler(this.frmIntegerAutobox_Load);
            this.ResumeLayout(false);

        }

        private void frmIntegerAutobox_Load(object sender, EventArgs e)
        {

        }
    }
}
