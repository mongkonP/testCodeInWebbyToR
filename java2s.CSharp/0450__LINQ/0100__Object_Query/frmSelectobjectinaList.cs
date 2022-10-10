using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0100__Object_Query
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/SelectobjectinaList.htm
    public partial  class frmSelectobjectinaList:Form
    {
        public frmSelectobjectinaList()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSelectobjectinaList
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSelectobjectinaList";
            this.Text = "frmSelectobjectinaList";
            this.Load += new System.EventHandler(this.frmSelectobjectinaList_Load);
            this.ResumeLayout(false);

        }

        private void frmSelectobjectinaList_Load(object sender, EventArgs e)
        {

        }
    }
}
