using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2380__Thread
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ThreadPoolQueueUserWorkItem.htm
    public partial  class frmThreadPoolQueueUserWorkItem:Form
    {
        public frmThreadPoolQueueUserWorkItem()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmThreadPoolQueueUserWorkItem
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmThreadPoolQueueUserWorkItem";
            this.Text = "frmThreadPoolQueueUserWorkItem";
            this.Load += new System.EventHandler(this.frmThreadPoolQueueUserWorkItem_Load);
            this.ResumeLayout(false);

        }

        private void frmThreadPoolQueueUserWorkItem_Load(object sender, EventArgs e)
        {

        }
    }
}
