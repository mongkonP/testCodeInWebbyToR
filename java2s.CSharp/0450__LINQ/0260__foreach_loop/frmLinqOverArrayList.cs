using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0260__foreach_loop
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/LinqOverArrayList.htm
    public partial  class frmLinqOverArrayList:Form
    {
        public frmLinqOverArrayList()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmLinqOverArrayList
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmLinqOverArrayList";
            this.Text = "frmLinqOverArrayList";
            this.Load += new System.EventHandler(this.frmLinqOverArrayList_Load);
            this.ResumeLayout(false);

        }

        private void frmLinqOverArrayList_Load(object sender, EventArgs e)
        {

        }
    }
}
