using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C1040__LongCount
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/LongCountPrototype.htm
    public partial  class frmLongCountPrototype:Form
    {
        public frmLongCountPrototype()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmLongCountPrototype
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmLongCountPrototype";
            this.Text = "frmLongCountPrototype";
            this.Load += new System.EventHandler(this.frmLongCountPrototype_Load);
            this.ResumeLayout(false);

        }

        private void frmLongCountPrototype_Load(object sender, EventArgs e)
        {

        }
    }
}
