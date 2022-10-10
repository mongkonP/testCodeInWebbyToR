using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0642__DataRelation
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/Navigateamanytomanyrelationship.htm
    public partial  class frmNavigateamanytomanyrelationship:Form
    {
        public frmNavigateamanytomanyrelationship()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmNavigateamanytomanyrelationship
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmNavigateamanytomanyrelationship";
            this.Text = "frmNavigateamanytomanyrelationship";
            this.Load += new System.EventHandler(this.frmNavigateamanytomanyrelationship_Load);
            this.ResumeLayout(false);

        }

        private void frmNavigateamanytomanyrelationship_Load(object sender, EventArgs e)
        {

        }
    }
}
