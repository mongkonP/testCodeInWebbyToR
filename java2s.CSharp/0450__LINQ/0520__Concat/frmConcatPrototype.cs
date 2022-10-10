using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0520__Concat
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/ConcatPrototype.htm
    public partial  class frmConcatPrototype:Form
    {
        public frmConcatPrototype()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmConcatPrototype
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmConcatPrototype";
            this.Text = "frmConcatPrototype";
            this.Load += new System.EventHandler(this.frmConcatPrototype_Load);
            this.ResumeLayout(false);

        }

        private void frmConcatPrototype_Load(object sender, EventArgs e)
        {

        }
    }
}
