using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0581__Directory_Services.C0140__Search
{
    //http://www.java2s.com/Tutorial/CSharp/0581__Directory-Services/SimpleSearch.htm
    public partial  class frmSimpleSearch:Form
    {
        public frmSimpleSearch()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSimpleSearch
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSimpleSearch";
            this.Text = "frmSimpleSearch";
            this.Load += new System.EventHandler(this.frmSimpleSearch_Load);
            this.ResumeLayout(false);

        }

        private void frmSimpleSearch_Load(object sender, EventArgs e)
        {

        }
    }
}
