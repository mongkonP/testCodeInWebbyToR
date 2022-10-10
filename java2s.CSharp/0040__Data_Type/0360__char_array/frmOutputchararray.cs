using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0040__Data_Type.C0360__char_array
{
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/Outputchararray.htm
    public partial  class frmOutputchararray:Form
    {
        public frmOutputchararray()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmOutputchararray
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmOutputchararray";
            this.Text = "frmOutputchararray";
            this.Load += new System.EventHandler(this.frmOutputchararray_Load);
            this.ResumeLayout(false);

        }

        private void frmOutputchararray_Load(object sender, EventArgs e)
        {

        }
    }
}
