using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0600__ListViewItem
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/ListViewitemactivationevent.htm
    public partial  class frmListViewitemactivationevent:Form
    {
        public frmListViewitemactivationevent()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmListViewitemactivationevent
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmListViewitemactivationevent";
            this.Text = "frmListViewitemactivationevent";
            this.Load += new System.EventHandler(this.frmListViewitemactivationevent_Load);
            this.ResumeLayout(false);

        }

        private void frmListViewitemactivationevent_Load(object sender, EventArgs e)
        {

        }
    }
}
