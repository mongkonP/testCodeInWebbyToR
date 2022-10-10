using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1900__Dispatcher
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/UseDispatcherTimertochangeDependencyProperty.htm
    public partial  class frmUseDispatcherTimertochangeDependencyProperty:Form
    {
        public frmUseDispatcherTimertochangeDependencyProperty()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseDispatcherTimertochangeDependencyProperty
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseDispatcherTimertochangeDependencyProperty";
            this.Text = "frmUseDispatcherTimertochangeDependencyProperty";
            this.Load += new System.EventHandler(this.frmUseDispatcherTimertochangeDependencyProperty_Load);
            this.ResumeLayout(false);

        }

        private void frmUseDispatcherTimertochangeDependencyProperty_Load(object sender, EventArgs e)
        {

        }
    }
}
