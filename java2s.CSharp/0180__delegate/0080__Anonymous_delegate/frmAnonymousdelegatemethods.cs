using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0180__delegate.C0080__Anonymous_delegate
{
    //http://www.java2s.com/Tutorial/CSharp/0180__delegate/Anonymousdelegatemethods.htm
    public partial  class frmAnonymousdelegatemethods:Form
    {
        public frmAnonymousdelegatemethods()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAnonymousdelegatemethods
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAnonymousdelegatemethods";
            this.Text = "frmAnonymousdelegatemethods";
            this.Load += new System.EventHandler(this.frmAnonymousdelegatemethods_Load);
            this.ResumeLayout(false);

        }

        private void frmAnonymousdelegatemethods_Load(object sender, EventArgs e)
        {

        }
    }
}
