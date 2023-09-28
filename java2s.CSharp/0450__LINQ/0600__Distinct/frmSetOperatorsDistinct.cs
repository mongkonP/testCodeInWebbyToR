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
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/SetOperatorsDistinct.htm
    public partial  class frmSetOperatorsDistinct:Form
    {
        public frmSetOperatorsDistinct()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSetOperatorsDistinct
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSetOperatorsDistinct";
            this.Text = "frmSetOperatorsDistinct";
            this.Load += new System.EventHandler(this.frmSetOperatorsDistinct_Load);
            this.ResumeLayout(false);

        }

        private void frmSetOperatorsDistinct_Load(object sender, EventArgs e)
        {

        }
    }
}
