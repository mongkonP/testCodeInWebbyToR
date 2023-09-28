using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0520__Windows.C0340__Bluetooth
{
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/BluetoothDemo.htm
    public partial  class frmBluetoothDemo:Form
    {
        public frmBluetoothDemo()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmBluetoothDemo
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmBluetoothDemo";
            this.Text = "frmBluetoothDemo";
            this.Load += new System.EventHandler(this.frmBluetoothDemo_Load);
            this.ResumeLayout(false);

        }

        private void frmBluetoothDemo_Load(object sender, EventArgs e)
        {

        }
    }
}
