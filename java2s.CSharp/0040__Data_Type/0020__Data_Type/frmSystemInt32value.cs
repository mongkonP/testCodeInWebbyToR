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
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/SystemInt32value.htm
    public partial  class frmSystemInt32value:Form
    {
        public frmSystemInt32value()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSystemInt32value
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSystemInt32value";
            this.Text = "frmSystemInt32value";
            this.Load += new System.EventHandler(this.frmSystemInt32value_Load);
            this.ResumeLayout(false);

        }

        private void frmSystemInt32value_Load(object sender, EventArgs e)
        {

        }
    }
}
