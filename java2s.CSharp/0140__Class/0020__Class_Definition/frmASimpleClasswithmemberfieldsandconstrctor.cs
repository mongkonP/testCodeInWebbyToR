using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0020__Class_Definition
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/ASimpleClasswithmemberfieldsandconstrctor.htm
    public partial  class frmASimpleClasswithmemberfieldsandconstrctor:Form
    {
        public frmASimpleClasswithmemberfieldsandconstrctor()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmASimpleClasswithmemberfieldsandconstrctor
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmASimpleClasswithmemberfieldsandconstrctor";
            this.Text = "frmASimpleClasswithmemberfieldsandconstrctor";
            this.Load += new System.EventHandler(this.frmASimpleClasswithmemberfieldsandconstrctor_Load);
            this.ResumeLayout(false);

        }

        private void frmASimpleClasswithmemberfieldsandconstrctor_Load(object sender, EventArgs e)
        {

        }
    }
}
