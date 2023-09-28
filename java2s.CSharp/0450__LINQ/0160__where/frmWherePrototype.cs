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
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/WherePrototype.htm
    public partial  class frmWherePrototype:Form
    {
        public frmWherePrototype()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmWherePrototype
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmWherePrototype";
            this.Text = "frmWherePrototype";
            this.Load += new System.EventHandler(this.frmWherePrototype_Load);
            this.ResumeLayout(false);

        }

        private void frmWherePrototype_Load(object sender, EventArgs e)
        {

        }
    }
}
