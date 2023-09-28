using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0040__Data_Type.C0280__byte_box_unbox
{
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/Boxingshort.htm
    public partial  class frmBoxingshort:Form
    {
        public frmBoxingshort()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmBoxingshort
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmBoxingshort";
            this.Text = "frmBoxingshort";
            this.Load += new System.EventHandler(this.frmBoxingshort_Load);
            this.ResumeLayout(false);

        }

        private void frmBoxingshort_Load(object sender, EventArgs e)
        {

        }
    }
}
