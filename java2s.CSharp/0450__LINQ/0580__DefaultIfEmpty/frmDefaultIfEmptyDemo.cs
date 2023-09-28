using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0580__DefaultIfEmpty
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/DefaultIfEmptyDemo.htm
    public partial  class frmDefaultIfEmptyDemo:Form
    {
        public frmDefaultIfEmptyDemo()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDefaultIfEmptyDemo
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDefaultIfEmptyDemo";
            this.Text = "frmDefaultIfEmptyDemo";
            this.Load += new System.EventHandler(this.frmDefaultIfEmptyDemo_Load);
            this.ResumeLayout(false);

        }

        private void frmDefaultIfEmptyDemo_Load(object sender, EventArgs e)
        {

        }
    }
}
