using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2000__Binding
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/CustomDialogwithdatabinding.htm
    public partial  class frmCustomDialogwithdatabinding:Form
    {
        public frmCustomDialogwithdatabinding()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCustomDialogwithdatabinding
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCustomDialogwithdatabinding";
            this.Text = "frmCustomDialogwithdatabinding";
            this.Load += new System.EventHandler(this.frmCustomDialogwithdatabinding_Load);
            this.ResumeLayout(false);

        }

        private void frmCustomDialogwithdatabinding_Load(object sender, EventArgs e)
        {

        }
    }
}
