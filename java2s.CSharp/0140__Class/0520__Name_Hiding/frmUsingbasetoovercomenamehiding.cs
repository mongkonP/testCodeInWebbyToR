using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0520__Name_Hiding
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Usingbasetoovercomenamehiding.htm
    public partial  class frmUsingbasetoovercomenamehiding:Form
    {
        public frmUsingbasetoovercomenamehiding()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingbasetoovercomenamehiding
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingbasetoovercomenamehiding";
            this.Text = "frmUsingbasetoovercomenamehiding";
            this.Load += new System.EventHandler(this.frmUsingbasetoovercomenamehiding_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingbasetoovercomenamehiding_Load(object sender, EventArgs e)
        {

        }
    }
}
