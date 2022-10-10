using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0040__Data_Type.C0800__Bits
{
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/Displaythebitswithinabyte.htm
    public partial  class frmDisplaythebitswithinabyte:Form
    {
        public frmDisplaythebitswithinabyte()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDisplaythebitswithinabyte
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDisplaythebitswithinabyte";
            this.Text = "frmDisplaythebitswithinabyte";
            this.Load += new System.EventHandler(this.frmDisplaythebitswithinabyte_Load);
            this.ResumeLayout(false);

        }

        private void frmDisplaythebitswithinabyte_Load(object sender, EventArgs e)
        {

        }
    }
}
