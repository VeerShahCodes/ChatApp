using ChatApp;

namespace ChatRoomApplication
{
    public partial class Form1 : Form
    {
        SQL Sql;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Sql = new SQL("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"\\\\GMRDC1\\Folder Redirection\\Veer.Shah\\Documents\\Visual Studio 2022\\Projects\\SQLAPIs\\ChatApp\\DBLibrary\\ChatRoomDB.mdf\";Integrated Security=True");
            menuPanel.Visible = true;
            createAccountPanel.Visible = false;
            loggedInPanel.Visible = false;
            loggingInPanel.Visible = false;
            createRoomPanel.Visible = false;
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            createAccountPanel.Visible = true;
            menuPanel.Visible = false;
        }

        private void enterAccountCreation_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text;
            string password = passwordBox.Text;
            object id;
            if (Sql.CreateAccount(username, password, out id))
            {
                loggedInPanel.Visible = true;
                createAccountPanel.Visible = false;
            }
            else
            {

            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            menuPanel.Visible = false;
            loggingInPanel.Visible = true;
        }

        private void logAccount_Click(object sender, EventArgs e)
        {
            string username = logUsername.Text;
            string password = logPassword.Text;
            object id;
            Exception error;
            if (Sql.Login(username, password, out id, out error))
            {
                loggingInPanel.Visible = false;
                loggedInPanel.Visible = true;
            }
            else
            {

            }
        }

        private void postCreateRoom_Click(object sender, EventArgs e)
        {
            string roomName = roomUsernameBox.Text;
            string roomPass = roomPassBox.Text;
            object roomId;
            if (Sql.CreateRoom(roomName, roomPass, out roomId))
            {
                createRoomPanel.Visible = false;
            }
        }

        private void joinRoomButton_Click(object sender, EventArgs e)
        {
            loggedInPanel.Visible = false;

        }
    }
}
