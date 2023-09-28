using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0380__Union
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/SetOperatorsUnion.htm
    public partial  class frmSetOperatorsUnion:Form
    {
        public frmSetOperatorsUnion()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSetOperatorsUnion
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSetOperatorsUnion";
            this.Text = "frmSetOperatorsUnion";
            this.Load += new System.EventHandler(this.frmSetOperatorsUnion_Load);
            this.ResumeLayout(false);

        }

        private void frmSetOperatorsUnion_Load(object sender, EventArgs e)
        {

        }
    }
}
