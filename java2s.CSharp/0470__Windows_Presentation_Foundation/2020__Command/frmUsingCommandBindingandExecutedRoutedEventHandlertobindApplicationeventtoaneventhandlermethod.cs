using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2020__Command
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/UsingCommandBindingandExecutedRoutedEventHandlertobindApplicationeventtoaneventhandlermethod.htm
    public partial  class frmUsingCommandBindingandExecutedRoutedEventHandlertobindApplicationeventtoaneventhandlermethod:Form
    {
        public frmUsingCommandBindingandExecutedRoutedEventHandlertobindApplicationeventtoaneventhandlermethod()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingCommandBindingandExecutedRoutedEventHandlertobindApplicationeventtoaneventhandlermethod
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingCommandBindingandExecutedRoutedEventHandlertobindApplicationeventtoaneventhandlermethod";
            this.Text = "frmUsingCommandBindingandExecutedRoutedEventHandlertobindApplicationeventtoaneventhandlermethod";
            this.Load += new System.EventHandler(this.frmUsingCommandBindingandExecutedRoutedEventHandlertobindApplicationeventtoaneventhandlermethod_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingCommandBindingandExecutedRoutedEventHandlertobindApplicationeventtoaneventhandlermethod_Load(object sender, EventArgs e)
        {

        }
    }
}
