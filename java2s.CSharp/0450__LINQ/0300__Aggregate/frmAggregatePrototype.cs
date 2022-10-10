using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0300__Aggregate
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/AggregatePrototype.htm
    public partial  class frmAggregatePrototype:Form
    {
        public frmAggregatePrototype()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAggregatePrototype
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAggregatePrototype";
            this.Text = "frmAggregatePrototype";
            this.Load += new System.EventHandler(this.frmAggregatePrototype_Load);
            this.ResumeLayout(false);

        }

        private void frmAggregatePrototype_Load(object sender, EventArgs e)
        {

        }
    }
}
