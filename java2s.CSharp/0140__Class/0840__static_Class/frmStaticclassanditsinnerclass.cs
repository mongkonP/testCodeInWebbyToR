using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0840__static_Class
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Staticclassanditsinnerclass.htm
    public partial  class frmStaticclassanditsinnerclass:Form
    {
        public frmStaticclassanditsinnerclass()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmStaticclassanditsinnerclass
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmStaticclassanditsinnerclass";
            this.Text = "frmStaticclassanditsinnerclass";
            this.Load += new System.EventHandler(this.frmStaticclassanditsinnerclass_Load);
            this.ResumeLayout(false);

        }

        private void frmStaticclassanditsinnerclass_Load(object sender, EventArgs e)
        {

        }
    }
}
