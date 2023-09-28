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
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/UshortToByteconvert.htm
    public partial  class frmUshortToByteconvert:Form
    {
        public frmUshortToByteconvert()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUshortToByteconvert
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUshortToByteconvert";
            this.Text = "frmUshortToByteconvert";
            this.Load += new System.EventHandler(this.frmUshortToByteconvert_Load);
            this.ResumeLayout(false);

        }

        private void frmUshortToByteconvert_Load(object sender, EventArgs e)
        {

        }
    }
}
