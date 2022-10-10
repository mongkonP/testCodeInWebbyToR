using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0600__Distinct
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/GetallMakeanddontshowduplicates.htm
    public partial  class frmGetallMakeanddontshowduplicates:Form
    {
        public frmGetallMakeanddontshowduplicates()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetallMakeanddontshowduplicates
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetallMakeanddontshowduplicates";
            this.Text = "frmGetallMakeanddontshowduplicates";
            this.Load += new System.EventHandler(this.frmGetallMakeanddontshowduplicates_Load);
            this.ResumeLayout(false);

        }

        private void frmGetallMakeanddontshowduplicates_Load(object sender, EventArgs e)
        {

        }
    }
}
