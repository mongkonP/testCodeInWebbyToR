using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0460__virtual
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/VirtualMethodsandOverriding.htm
    public partial  class frmVirtualMethodsandOverriding:Form
    {
        public frmVirtualMethodsandOverriding()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmVirtualMethodsandOverriding
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmVirtualMethodsandOverriding";
            this.Text = "frmVirtualMethodsandOverriding";
            this.Load += new System.EventHandler(this.frmVirtualMethodsandOverriding_Load);
            this.ResumeLayout(false);

        }

        private void frmVirtualMethodsandOverriding_Load(object sender, EventArgs e)
        {

        }
    }
}
