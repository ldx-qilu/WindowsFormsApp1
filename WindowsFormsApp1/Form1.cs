using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SAPLogonCtrl;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SAPLogonCtrl.SAPLogonControlClass logon = new SAPLogonCtrl.SAPLogonControlClass();
            logon.ApplicationServer = "192.168.95.20";                 //SAP system's IP
            logon.Client = "310";                                             //SAP system'client
            logon.Language = "ZH";
            logon.User = "ZBT_RFC";                              //Username
            logon.Password = "Zbt_rfc123";                               //Password
            logon.SystemNumber = 00;                                 //System number
            SAPLogonCtrl.Connection conn = (SAPLogonCtrl.Connection)logon.NewConnection();
            if (conn.Logon(null, true))
            {
                MessageBox.Show("连接SAP成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Logoff();
            }
            else
            {
                MessageBox.Show("连接SAP失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }

        }
    }
}
