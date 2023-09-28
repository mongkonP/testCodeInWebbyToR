using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0340__ListBox
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ListBoxselectionchangedevent.htm
    public partial  class frmListBoxselectionchangedevent:Form
    {
        public frmListBoxselectionchangedevent()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmListBoxselectionchangedevent
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmListBoxselectionchangedevent";
            this.Text = "frmListBoxselectionchangedevent";
            this.Load += new System.EventHandler(this.frmListBoxselectionchangedevent_Load);
            this.ResumeLayout(false);

        }

        private void frmListBoxselectionchangedevent_Load(object sender, EventArgs e)
        {

        }
    }
}
