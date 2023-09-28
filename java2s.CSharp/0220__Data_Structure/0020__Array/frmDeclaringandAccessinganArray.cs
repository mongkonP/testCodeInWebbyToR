using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0020__Array
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/DeclaringandAccessinganArray.htm
    public partial  class frmDeclaringandAccessinganArray:Form
    {
        public frmDeclaringandAccessinganArray()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDeclaringandAccessinganArray
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDeclaringandAccessinganArray";
            this.Text = "frmDeclaringandAccessinganArray";
            this.Load += new System.EventHandler(this.frmDeclaringandAccessinganArray_Load);
            this.ResumeLayout(false);

        }

        private void frmDeclaringandAccessinganArray_Load(object sender, EventArgs e)
        {

        }
    }
}
