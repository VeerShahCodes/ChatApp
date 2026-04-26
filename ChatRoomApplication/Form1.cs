using ChatApp;
using Microsoft.VisualBasic.ApplicationServices;

namespace ChatRoomApplication
{
    public partial class Form1 : Form
    {
        SQL Sql;
        int userId;
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
            joinRoomPanel.Visible = false;
            viewRoomPanel.Visible = false;
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
            userId = (int)id;
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
                Console.WriteLine("invalid username or password");
            }
            userId = (int)id;

        }

        private void postCreateRoom_Click(object sender, EventArgs e)
        {
            string roomName = roomUsernameBox.Text;
            string roomPass = roomPassBox.Text;
            object roomId;
            if (Sql.CreateRoom(roomName, roomPass, out roomId))
            {
                createRoomPanel.Visible = false;
                loggedInPanel.Visible = true;
            }
        }

        private void joinRoomButton_Click(object sender, EventArgs e)
        {
            loggedInPanel.Visible = false;
            joinRoomPanel.Visible = true;
        }

        private void createRoomButton_Click(object sender, EventArgs e)
        {
            loggedInPanel.Visible = false;
            createRoomPanel.Visible = true;
        }

        private void getJoinRoomButton_Click(object sender, EventArgs e)
        {
            string roomName = joinRoomUsernameBox.Text;
            string roomPassword = joinRoomPasswordBox.Text;
            object roomId;
            if (Sql.JoinRoom(roomName, roomPassword, out roomId))
            {
                if (Sql.CreateAccountRoom(userId, (int)roomId))
                {
                    joinRoomPanel.Visible = false;
                    loggedInPanel.Visible = true;
                }
            }
            else
            {
                Console.WriteLine("Invalid room");
            }
        }

        
        private void viewRoomsButton_Click(object sender, EventArgs e)
        {
            loggedInPanel.Visible = false;
            List<int> roomIds = Sql.GetRooms(userId);
            List<string> roomNames = Sql.GetRoomNames(roomIds);
            viewRoomPanel.Visible = true;
            int availableHeight = Size.Height;
            int labelHeight = availableHeight / roomIds.Count;

            for(int i = 0; i < availableHeight / labelHeight; i++)
            {
                Label label = new Label();
                viewRoomPanel.Controls.Add(label);
                label.Location = new Point(0, i * labelHeight);
                label.AutoSize = true;
                label.Font = new Font("Segoe UI", labelHeight / 2);
                label.Text = roomNames[i];
                label.Click += room_Click;
            }
        }

        private void room_Click(object sender, EventArgs e)
        {
            viewRoomPanel.Visible = false;
          
        }
    }
}
