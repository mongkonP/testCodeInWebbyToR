using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0620__unsafe.C0019__unsafe
{
    //http://www.java2s.com/Tutorial/CSharp/0620__unsafe/Markmethodasunsafetopointers.htm
    public partial  class frmMarkmethodasunsafetopointers:Form
    {
        public frmMarkmethodasunsafetopointers()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMarkmethodasunsafetopointers
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmMarkmethodasunsafetopointers";
            this.Text = "frmMarkmethodasunsafetopointers";
            this.Load += new System.EventHandler(this.frmMarkmethodasunsafetopointers_Load);
            this.ResumeLayout(false);

        }

        private void frmMarkmethodasunsafetopointers_Load(object sender, EventArgs e)
        {

        }
    }
}
