using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0500__Design_Patterns.C0060__Observer_Pattern
{
    //http://www.java2s.com/Tutorial/CSharp/0500__Design-Patterns/ObserverDesignPattern.htm
    public partial  class frmObserverDesignPattern:Form
    {
        public frmObserverDesignPattern()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmObserverDesignPattern
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmObserverDesignPattern";
            this.Text = "frmObserverDesignPattern";
            this.Load += new System.EventHandler(this.frmObserverDesignPattern_Load);
            this.ResumeLayout(false);

        }

        private void frmObserverDesignPattern_Load(object sender, EventArgs e)
        {

        }
    }
}
