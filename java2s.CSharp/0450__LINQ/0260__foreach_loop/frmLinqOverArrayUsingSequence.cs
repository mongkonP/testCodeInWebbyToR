using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0260__foreach_loop
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/LinqOverArrayUsingSequence.htm
    public partial  class frmLinqOverArrayUsingSequence:Form
    {
        public frmLinqOverArrayUsingSequence()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmLinqOverArrayUsingSequence
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmLinqOverArrayUsingSequence";
            this.Text = "frmLinqOverArrayUsingSequence";
            this.Load += new System.EventHandler(this.frmLinqOverArrayUsingSequence_Load);
            this.ResumeLayout(false);

        }

        private void frmLinqOverArrayUsingSequence_Load(object sender, EventArgs e)
        {

        }
    }
}
