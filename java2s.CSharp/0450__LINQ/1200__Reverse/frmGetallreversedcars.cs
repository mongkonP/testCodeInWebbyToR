using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C1200__Reverse
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/Getallreversedcars.htm
    public partial  class frmGetallreversedcars:Form
    {
        public frmGetallreversedcars()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetallreversedcars
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetallreversedcars";
            this.Text = "frmGetallreversedcars";
            this.Load += new System.EventHandler(this.frmGetallreversedcars_Load);
            this.ResumeLayout(false);

        }

        private void frmGetallreversedcars_Load(object sender, EventArgs e)
        {

        }
    }
}
