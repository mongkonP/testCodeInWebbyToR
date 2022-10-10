using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1480__SolidColorBrush
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/UsingSolidColorBrushtopaintthewindowbackground.htm
    public partial  class frmUsingSolidColorBrushtopaintthewindowbackground:Form
    {
        public frmUsingSolidColorBrushtopaintthewindowbackground()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingSolidColorBrushtopaintthewindowbackground
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingSolidColorBrushtopaintthewindowbackground";
            this.Text = "frmUsingSolidColorBrushtopaintthewindowbackground";
            this.Load += new System.EventHandler(this.frmUsingSolidColorBrushtopaintthewindowbackground_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingSolidColorBrushtopaintthewindowbackground_Load(object sender, EventArgs e)
        {

        }
    }
}
