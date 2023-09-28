using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0040__Data_Type.C0301__ushort
{
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/ushortvalue.htm
    public partial  class frmushortvalue:Form
    {
        public frmushortvalue()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmushortvalue
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmushortvalue";
            this.Text = "frmushortvalue";
            this.Load += new System.EventHandler(this.frmushortvalue_Load);
            this.ResumeLayout(false);

        }

        private void frmushortvalue_Load(object sender, EventArgs e)
        {

        }
    }
}
