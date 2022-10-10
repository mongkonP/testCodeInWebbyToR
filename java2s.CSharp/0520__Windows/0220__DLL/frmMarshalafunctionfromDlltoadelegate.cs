using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0520__Windows.C0220__DLL
{
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/MarshalafunctionfromDlltoadelegate.htm
    public partial  class frmMarshalafunctionfromDlltoadelegate:Form
    {
        public frmMarshalafunctionfromDlltoadelegate()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMarshalafunctionfromDlltoadelegate
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmMarshalafunctionfromDlltoadelegate";
            this.Text = "frmMarshalafunctionfromDlltoadelegate";
            this.Load += new System.EventHandler(this.frmMarshalafunctionfromDlltoadelegate_Load);
            this.ResumeLayout(false);

        }

        private void frmMarshalafunctionfromDlltoadelegate_Load(object sender, EventArgs e)
        {

        }
    }
}
