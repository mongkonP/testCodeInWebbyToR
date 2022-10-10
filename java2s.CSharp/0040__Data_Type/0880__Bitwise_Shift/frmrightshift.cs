using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0040__Data_Type.C0880__Bitwise_Shift
{
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/rightshift.htm
    public partial  class frmrightshift:Form
    {
        public frmrightshift()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmrightshift
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmrightshift";
            this.Text = "frmrightshift";
            this.Load += new System.EventHandler(this.frmrightshift_Load);
            this.ResumeLayout(false);

        }

        private void frmrightshift_Load(object sender, EventArgs e)
        {

        }
    }
}
