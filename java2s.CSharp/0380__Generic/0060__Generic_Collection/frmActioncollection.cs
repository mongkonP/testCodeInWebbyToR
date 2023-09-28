using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0380__Generic.C0060__Generic_Collection
{
    //http://www.java2s.com/Tutorial/CSharp/0380__Generic/Actioncollection.htm
    public partial  class frmActioncollection:Form
    {
        public frmActioncollection()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmActioncollection
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmActioncollection";
            this.Text = "frmActioncollection";
            this.Load += new System.EventHandler(this.frmActioncollection_Load);
            this.ResumeLayout(false);

        }

        private void frmActioncollection_Load(object sender, EventArgs e)
        {

        }
    }
}
