using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0160__where
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/Queryforfilteringnumbers.htm
    public partial  class frmQueryforfilteringnumbers:Form
    {
        public frmQueryforfilteringnumbers()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmQueryforfilteringnumbers
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmQueryforfilteringnumbers";
            this.Text = "frmQueryforfilteringnumbers";
            this.Load += new System.EventHandler(this.frmQueryforfilteringnumbers_Load);
            this.ResumeLayout(false);

        }

        private void frmQueryforfilteringnumbers_Load(object sender, EventArgs e)
        {

        }
    }
}
