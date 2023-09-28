using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0580__ThreadPool
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/Schedulingworktooccuronthethreadpool.htm
    public partial  class frmSchedulingworktooccuronthethreadpool:Form
    {
        public frmSchedulingworktooccuronthethreadpool()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSchedulingworktooccuronthethreadpool
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSchedulingworktooccuronthethreadpool";
            this.Text = "frmSchedulingworktooccuronthethreadpool";
            this.Load += new System.EventHandler(this.frmSchedulingworktooccuronthethreadpool_Load);
            this.ResumeLayout(false);

        }

        private void frmSchedulingworktooccuronthethreadpool_Load(object sender, EventArgs e)
        {

        }
    }
}
