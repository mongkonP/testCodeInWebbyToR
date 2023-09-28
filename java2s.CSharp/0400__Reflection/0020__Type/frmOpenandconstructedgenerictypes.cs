using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0400__Reflection.C0020__Type
{
    //http://www.java2s.com/Tutorial/CSharp/0400__Reflection/Openandconstructedgenerictypes.htm
    public partial  class frmOpenandconstructedgenerictypes:Form
    {
        public frmOpenandconstructedgenerictypes()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmOpenandconstructedgenerictypes
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmOpenandconstructedgenerictypes";
            this.Text = "frmOpenandconstructedgenerictypes";
            this.Load += new System.EventHandler(this.frmOpenandconstructedgenerictypes_Load);
            this.ResumeLayout(false);

        }

        private void frmOpenandconstructedgenerictypes_Load(object sender, EventArgs e)
        {

        }
    }
}
