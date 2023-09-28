using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0040__Data_Type.C0020__Data_Type
{
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/SystemUInt16value.htm
    public partial  class frmSystemUInt16value:Form
    {
        public frmSystemUInt16value()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSystemUInt16value
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSystemUInt16value";
            this.Text = "frmSystemUInt16value";
            this.Load += new System.EventHandler(this.frmSystemUInt16value_Load);
            this.ResumeLayout(false);

        }

        private void frmSystemUInt16value_Load(object sender, EventArgs e)
        {

        }
    }
}
