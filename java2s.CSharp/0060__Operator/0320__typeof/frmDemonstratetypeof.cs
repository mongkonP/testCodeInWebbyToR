using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0060__Operator.C0320__typeof
{
    //http://www.java2s.com/Tutorial/CSharp/0060__Operator/Demonstratetypeof.htm
    public partial  class frmDemonstratetypeof:Form
    {
        public frmDemonstratetypeof()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDemonstratetypeof
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDemonstratetypeof";
            this.Text = "frmDemonstratetypeof";
            this.Load += new System.EventHandler(this.frmDemonstratetypeof_Load);
            this.ResumeLayout(false);

        }

        private void frmDemonstratetypeof_Load(object sender, EventArgs e)
        {

        }
    }
}
