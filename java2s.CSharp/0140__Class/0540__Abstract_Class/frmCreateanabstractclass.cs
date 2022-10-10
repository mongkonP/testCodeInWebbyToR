using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0540__Abstract_Class
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Createanabstractclass.htm
    public partial  class frmCreateanabstractclass:Form
    {
        public frmCreateanabstractclass()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreateanabstractclass
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreateanabstractclass";
            this.Text = "frmCreateanabstractclass";
            this.Load += new System.EventHandler(this.frmCreateanabstractclass_Load);
            this.ResumeLayout(false);

        }

        private void frmCreateanabstractclass_Load(object sender, EventArgs e)
        {

        }
    }
}
