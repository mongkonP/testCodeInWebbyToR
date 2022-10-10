using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0480__ScrollBar
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/UseScrollBartocontrolPicture.htm
    public partial  class frmUseScrollBartocontrolPicture:Form
    {
        public frmUseScrollBartocontrolPicture()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseScrollBartocontrolPicture
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseScrollBartocontrolPicture";
            this.Text = "frmUseScrollBartocontrolPicture";
            this.Load += new System.EventHandler(this.frmUseScrollBartocontrolPicture_Load);
            this.ResumeLayout(false);

        }

        private void frmUseScrollBartocontrolPicture_Load(object sender, EventArgs e)
        {

        }
    }
}
