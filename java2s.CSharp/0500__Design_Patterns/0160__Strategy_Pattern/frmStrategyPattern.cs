using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0500__Design_Patterns.C0160__Strategy_Pattern
{
    //http://www.java2s.com/Tutorial/CSharp/0500__Design-Patterns/StrategyPattern.htm
    public partial  class frmStrategyPattern:Form
    {
        public frmStrategyPattern()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmStrategyPattern
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmStrategyPattern";
            this.Text = "frmStrategyPattern";
            this.Load += new System.EventHandler(this.frmStrategyPattern_Load);
            this.ResumeLayout(false);

        }

        private void frmStrategyPattern_Load(object sender, EventArgs e)
        {

        }
    }
}
