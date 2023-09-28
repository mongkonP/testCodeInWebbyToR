using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0500__Design_Patterns.C0140__Observer_Pattern
{
    //http://www.java2s.com/Tutorial/CSharp/0500__Design-Patterns/ObserverPatterns.htm
    public partial  class frmObserverPatterns:Form
    {
        public frmObserverPatterns()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmObserverPatterns
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmObserverPatterns";
            this.Text = "frmObserverPatterns";
            this.Load += new System.EventHandler(this.frmObserverPatterns_Load);
            this.ResumeLayout(false);

        }

        private void frmObserverPatterns_Load(object sender, EventArgs e)
        {

        }
    }
}
