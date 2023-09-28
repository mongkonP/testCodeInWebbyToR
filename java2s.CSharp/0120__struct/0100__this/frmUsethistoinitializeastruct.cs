using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0120__struct.C0100__this
{
    //http://www.java2s.com/Tutorial/CSharp/0120__struct/Usethistoinitializeastruct.htm
    public partial  class frmUsethistoinitializeastruct:Form
    {
        public frmUsethistoinitializeastruct()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsethistoinitializeastruct
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsethistoinitializeastruct";
            this.Text = "frmUsethistoinitializeastruct";
            this.Load += new System.EventHandler(this.frmUsethistoinitializeastruct_Load);
            this.ResumeLayout(false);

        }

        private void frmUsethistoinitializeastruct_Load(object sender, EventArgs e)
        {

        }
    }
}
