using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0400__Reflection.C0080__Method
{
    //http://www.java2s.com/Tutorial/CSharp/0400__Reflection/ListMethods.htm
    public partial  class frmListMethods:Form
    {
        public frmListMethods()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmListMethods
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmListMethods";
            this.Text = "frmListMethods";
            this.Load += new System.EventHandler(this.frmListMethods_Load);
            this.ResumeLayout(false);

        }

        private void frmListMethods_Load(object sender, EventArgs e)
        {

        }
    }
}
