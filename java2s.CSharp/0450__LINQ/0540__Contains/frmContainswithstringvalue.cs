using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0540__Contains
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/Containswithstringvalue.htm
    public partial  class frmContainswithstringvalue:Form
    {
        public frmContainswithstringvalue()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmContainswithstringvalue
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmContainswithstringvalue";
            this.Text = "frmContainswithstringvalue";
            this.Load += new System.EventHandler(this.frmContainswithstringvalue_Load);
            this.ResumeLayout(false);

        }

        private void frmContainswithstringvalue_Load(object sender, EventArgs e)
        {

        }
    }
}
