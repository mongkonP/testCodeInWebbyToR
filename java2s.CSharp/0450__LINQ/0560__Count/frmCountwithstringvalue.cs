using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0560__Count
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/Countwithstringvalue.htm
    public partial  class frmCountwithstringvalue:Form
    {
        public frmCountwithstringvalue()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCountwithstringvalue
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCountwithstringvalue";
            this.Text = "frmCountwithstringvalue";
            this.Load += new System.EventHandler(this.frmCountwithstringvalue_Load);
            this.ResumeLayout(false);

        }

        private void frmCountwithstringvalue_Load(object sender, EventArgs e)
        {

        }
    }
}
