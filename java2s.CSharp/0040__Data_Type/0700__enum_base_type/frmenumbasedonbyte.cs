using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0040__Data_Type.C0700__enum_base_type
{
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/enumbasedonbyte.htm
    public partial  class frmenumbasedonbyte:Form
    {
        public frmenumbasedonbyte()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmenumbasedonbyte
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmenumbasedonbyte";
            this.Text = "frmenumbasedonbyte";
            this.Load += new System.EventHandler(this.frmenumbasedonbyte_Load);
            this.ResumeLayout(false);

        }

        private void frmenumbasedonbyte_Load(object sender, EventArgs e)
        {

        }
    }
}
