using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0440__ArrayList_object
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/AddreferenceobjectstoArrayList.htm
    public partial  class frmAddreferenceobjectstoArrayList:Form
    {
        public frmAddreferenceobjectstoArrayList()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddreferenceobjectstoArrayList
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddreferenceobjectstoArrayList";
            this.Text = "frmAddreferenceobjectstoArrayList";
            this.Load += new System.EventHandler(this.frmAddreferenceobjectstoArrayList_Load);
            this.ResumeLayout(false);

        }

        private void frmAddreferenceobjectstoArrayList_Load(object sender, EventArgs e)
        {

        }
    }
}
