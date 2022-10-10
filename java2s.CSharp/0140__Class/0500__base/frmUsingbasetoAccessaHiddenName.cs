using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0500__base
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/UsingbasetoAccessaHiddenName.htm
    public partial  class frmUsingbasetoAccessaHiddenName:Form
    {
        public frmUsingbasetoAccessaHiddenName()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingbasetoAccessaHiddenName
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingbasetoAccessaHiddenName";
            this.Text = "frmUsingbasetoAccessaHiddenName";
            this.Load += new System.EventHandler(this.frmUsingbasetoAccessaHiddenName_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingbasetoAccessaHiddenName_Load(object sender, EventArgs e)
        {

        }
    }
}
