using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0900__Group
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/Groupingbysubstring.htm
    public partial  class frmGroupingbysubstring:Form
    {
        public frmGroupingbysubstring()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGroupingbysubstring
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGroupingbysubstring";
            this.Text = "frmGroupingbysubstring";
            this.Load += new System.EventHandler(this.frmGroupingbysubstring_Load);
            this.ResumeLayout(false);

        }

        private void frmGroupingbysubstring_Load(object sender, EventArgs e)
        {

        }
    }
}
