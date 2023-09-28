using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0160__Method_Overload
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/MethodOverloading.htm
    public partial  class frmMethodOverloading:Form
    {
        public frmMethodOverloading()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMethodOverloading
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmMethodOverloading";
            this.Text = "frmMethodOverloading";
            this.Load += new System.EventHandler(this.frmMethodOverloading_Load);
            this.ResumeLayout(false);

        }

        private void frmMethodOverloading_Load(object sender, EventArgs e)
        {

        }
    }
}
