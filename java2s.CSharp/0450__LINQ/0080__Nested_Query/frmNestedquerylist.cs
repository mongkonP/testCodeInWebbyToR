using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0080__Nested_Query
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/Nestedquerylist.htm
    public partial  class frmNestedquerylist:Form
    {
        public frmNestedquerylist()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmNestedquerylist
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmNestedquerylist";
            this.Text = "frmNestedquerylist";
            this.Load += new System.EventHandler(this.frmNestedquerylist_Load);
            this.ResumeLayout(false);

        }

        private void frmNestedquerylist_Load(object sender, EventArgs e)
        {

        }
    }
}
