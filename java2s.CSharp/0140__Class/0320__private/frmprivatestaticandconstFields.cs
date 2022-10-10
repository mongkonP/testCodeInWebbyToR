using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0320__private
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/privatestaticandconstFields.htm
    public partial  class frmprivatestaticandconstFields:Form
    {
        public frmprivatestaticandconstFields()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmprivatestaticandconstFields
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmprivatestaticandconstFields";
            this.Text = "frmprivatestaticandconstFields";
            this.Load += new System.EventHandler(this.frmprivatestaticandconstFields_Load);
            this.ResumeLayout(false);

        }

        private void frmprivatestaticandconstFields_Load(object sender, EventArgs e)
        {

        }
    }
}
