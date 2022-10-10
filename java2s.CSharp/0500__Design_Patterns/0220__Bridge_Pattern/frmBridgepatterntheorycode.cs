using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0500__Design_Patterns.C0220__Bridge_Pattern
{
    //http://www.java2s.com/Tutorial/CSharp/0500__Design-Patterns/Bridgepatterntheorycode.htm
    public partial  class frmBridgepatterntheorycode:Form
    {
        public frmBridgepatterntheorycode()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmBridgepatterntheorycode
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmBridgepatterntheorycode";
            this.Text = "frmBridgepatterntheorycode";
            this.Load += new System.EventHandler(this.frmBridgepatterntheorycode_Load);
            this.ResumeLayout(false);

        }

        private void frmBridgepatterntheorycode_Load(object sender, EventArgs e)
        {

        }
    }
}
