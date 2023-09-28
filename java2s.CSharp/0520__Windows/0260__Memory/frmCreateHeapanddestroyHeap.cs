using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0520__Windows.C0260__Memory
{
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/CreateHeapanddestroyHeap.htm
    public partial  class frmCreateHeapanddestroyHeap:Form
    {
        public frmCreateHeapanddestroyHeap()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreateHeapanddestroyHeap
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreateHeapanddestroyHeap";
            this.Text = "frmCreateHeapanddestroyHeap";
            this.Load += new System.EventHandler(this.frmCreateHeapanddestroyHeap_Load);
            this.ResumeLayout(false);

        }

        private void frmCreateHeapanddestroyHeap_Load(object sender, EventArgs e)
        {

        }
    }
}
