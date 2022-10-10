using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0580__Partial_Class
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Defineandusepartialclass.htm
    public partial  class frmDefineandusepartialclass:Form
    {
        public frmDefineandusepartialclass()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDefineandusepartialclass
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDefineandusepartialclass";
            this.Text = "frmDefineandusepartialclass";
            this.Load += new System.EventHandler(this.frmDefineandusepartialclass_Load);
            this.ResumeLayout(false);

        }

        private void frmDefineandusepartialclass_Load(object sender, EventArgs e)
        {

        }
    }
}
