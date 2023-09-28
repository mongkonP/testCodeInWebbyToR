using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0960__ToString
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/markoverridewhenoverridingToString.htm
    public partial  class frmmarkoverridewhenoverridingToString:Form
    {
        public frmmarkoverridewhenoverridingToString()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmmarkoverridewhenoverridingToString
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmmarkoverridewhenoverridingToString";
            this.Text = "frmmarkoverridewhenoverridingToString";
            this.Load += new System.EventHandler(this.frmmarkoverridewhenoverridingToString_Load);
            this.ResumeLayout(false);

        }

        private void frmmarkoverridewhenoverridingToString_Load(object sender, EventArgs e)
        {

        }
    }
}
