using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0340__Timer
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/UsetheTimertotriggerevent.htm
    public partial  class frmUsetheTimertotriggerevent:Form
    {
        public frmUsetheTimertotriggerevent()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsetheTimertotriggerevent
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsetheTimertotriggerevent";
            this.Text = "frmUsetheTimertotriggerevent";
            this.Load += new System.EventHandler(this.frmUsetheTimertotriggerevent_Load);
            this.ResumeLayout(false);

        }

        private void frmUsetheTimertotriggerevent_Load(object sender, EventArgs e)
        {

        }
    }
}
