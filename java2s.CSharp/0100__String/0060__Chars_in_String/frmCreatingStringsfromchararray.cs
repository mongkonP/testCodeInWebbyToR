using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0100__String.C0060__Chars_in_String
{
    //http://www.java2s.com/Tutorial/CSharp/0100__String/CreatingStringsfromchararray.htm
    public partial  class frmCreatingStringsfromchararray:Form
    {
        public frmCreatingStringsfromchararray()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreatingStringsfromchararray
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreatingStringsfromchararray";
            this.Text = "frmCreatingStringsfromchararray";
            this.Load += new System.EventHandler(this.frmCreatingStringsfromchararray_Load);
            this.ResumeLayout(false);

        }

        private void frmCreatingStringsfromchararray_Load(object sender, EventArgs e)
        {

        }
    }
}
