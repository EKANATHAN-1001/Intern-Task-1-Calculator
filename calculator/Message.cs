using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Message : UserControl
    {
        public delegate void MessageReadEventHandler(object sender,string n);

        public static event MessageReadEventHandler MessageReadEvent;
        private void OnMessageReadEvent(String notification)
        {
            MessageReadEvent.Invoke(this,notification);
        }

        public string Num
        {
            get { return num.Text; }
            set { num.Text = value; }
        }
        public string Msg
        {
            get { return msg.Text; }
            set { msg.Text = value; }
        }
        public Message()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            msg.Text = "Msg Read by you"; 
            OnMessageReadEvent("Message Read Successfull");
        }
    }
}
