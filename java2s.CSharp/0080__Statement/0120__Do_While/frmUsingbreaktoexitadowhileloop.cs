using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0080__Statement.C0120__Do_While
{
    //http://www.java2s.com/Tutorial/CSharp/0080__Statement/Usingbreaktoexitadowhileloop.htm
    public partial  class frmUsingbreaktoexitadowhileloop:Form
    {
        public frmUsingbreaktoexitadowhileloop()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingbreaktoexitadowhileloop
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingbreaktoexitadowhileloop";
            this.Text = "frmUsingbreaktoexitadowhileloop";
            this.Load += new System.EventHandler(this.frmUsingbreaktoexitadowhileloop_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingbreaktoexitadowhileloop_Load(object sender, EventArgs e)
        {

        }
    }
}
