using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0300__Array_ForEach
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/AnActiontriggeredbyArrayForEach.htm
    public partial  class frmAnActiontriggeredbyArrayForEach:Form
    {
        public frmAnActiontriggeredbyArrayForEach()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAnActiontriggeredbyArrayForEach
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAnActiontriggeredbyArrayForEach";
            this.Text = "frmAnActiontriggeredbyArrayForEach";
            this.Load += new System.EventHandler(this.frmAnActiontriggeredbyArrayForEach_Load);
            this.ResumeLayout(false);

        }

        private void frmAnActiontriggeredbyArrayForEach_Load(object sender, EventArgs e)
        {

        }
    }
}
