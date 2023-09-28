using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C1140__Prototype
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/WherebyPrototype.htm
    public partial  class frmWherebyPrototype:Form
    {
        public frmWherebyPrototype()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmWherebyPrototype
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmWherebyPrototype";
            this.Text = "frmWherebyPrototype";
            this.Load += new System.EventHandler(this.frmWherebyPrototype_Load);
            this.ResumeLayout(false);

        }

        private void frmWherebyPrototype_Load(object sender, EventArgs e)
        {

        }
    }
}
