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
    //http://www.java2s.com/Tutorial/CSharp/0400__Reflection/typeidentity.htm
    public partial  class frmtypeidentity:Form
    {
        public frmtypeidentity()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmtypeidentity
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmtypeidentity";
            this.Text = "frmtypeidentity";
            this.Load += new System.EventHandler(this.frmtypeidentity_Load);
            this.ResumeLayout(false);

        }

        private void frmtypeidentity_Load(object sender, EventArgs e)
        {

        }
    }
}
