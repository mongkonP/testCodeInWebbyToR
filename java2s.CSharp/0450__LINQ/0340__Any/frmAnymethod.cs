using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0340__Any
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/Anymethod.htm
    public partial  class frmAnymethod:Form
    {
        public frmAnymethod()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAnymethod
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAnymethod";
            this.Text = "frmAnymethod";
            this.Load += new System.EventHandler(this.frmAnymethod_Load);
            this.ResumeLayout(false);

        }

        private void frmAnymethod_Load(object sender, EventArgs e)
        {

        }
    }
}
