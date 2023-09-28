using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0980__Intersect
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/SetOperatorsIntersect.htm
    public partial  class frmSetOperatorsIntersect:Form
    {
        public frmSetOperatorsIntersect()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSetOperatorsIntersect
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSetOperatorsIntersect";
            this.Text = "frmSetOperatorsIntersect";
            this.Load += new System.EventHandler(this.frmSetOperatorsIntersect_Load);
            this.ResumeLayout(false);

        }

        private void frmSetOperatorsIntersect_Load(object sender, EventArgs e)
        {

        }
    }
}
