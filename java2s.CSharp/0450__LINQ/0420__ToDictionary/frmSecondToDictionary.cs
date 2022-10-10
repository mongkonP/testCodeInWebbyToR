using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0420__ToDictionary
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/SecondToDictionary.htm
    public partial  class frmSecondToDictionary:Form
    {
        public frmSecondToDictionary()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSecondToDictionary
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSecondToDictionary";
            this.Text = "frmSecondToDictionary";
            this.Load += new System.EventHandler(this.frmSecondToDictionary_Load);
            this.ResumeLayout(false);

        }

        private void frmSecondToDictionary_Load(object sender, EventArgs e)
        {

        }
    }
}
