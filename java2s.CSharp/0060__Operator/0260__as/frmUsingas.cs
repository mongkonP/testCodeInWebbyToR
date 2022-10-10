using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0060__Operator.C0260__as
{
    //http://www.java2s.com/Tutorial/CSharp/0060__Operator/Usingas.htm
    public partial  class frmUsingas:Form
    {
        public frmUsingas()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingas
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingas";
            this.Text = "frmUsingas";
            this.Load += new System.EventHandler(this.frmUsingas_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingas_Load(object sender, EventArgs e)
        {

        }
    }
}
