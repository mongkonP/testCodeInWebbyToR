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
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/Simplemethodbasedquery.htm
    public partial  class frmSimplemethodbasedquery:Form
    {
        public frmSimplemethodbasedquery()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSimplemethodbasedquery
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSimplemethodbasedquery";
            this.Text = "frmSimplemethodbasedquery";
            this.Load += new System.EventHandler(this.frmSimplemethodbasedquery_Load);
            this.ResumeLayout(false);

        }

        private void frmSimplemethodbasedquery_Load(object sender, EventArgs e)
        {

        }
    }
}
