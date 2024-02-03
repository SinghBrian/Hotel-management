namespace Admin_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string name = txtBoxName.Text;
            string passwd = textBoxPswd.Text;
            if (name == "admin" && passwd =="admin")
            {
                ControlPanel cp = new ControlPanel();
                cp.Show();
                
            }
            else { MessageBox.Show("Vous n'êtes pas admin !!"); }
        }
    }
}