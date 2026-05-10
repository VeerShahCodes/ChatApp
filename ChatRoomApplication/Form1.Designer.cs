namespace ChatRoomApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            loginButton = new Button();
            createAccountButton = new Button();
            createAccountPanel = new Panel();
            backButton5 = new Label();
            enterAccountCreation = new Button();
            passwordBox = new TextBox();
            usernameBox = new TextBox();
            menuPanel = new Panel();
            loggedInPanel = new Panel();
            logoutButton = new Label();
            viewRoomsButton = new Button();
            joinRoomButton = new Button();
            createRoomButton = new Button();
            label2 = new Label();
            loggingInPanel = new Panel();
            logAccount = new Button();
            logPassword = new TextBox();
            logUsername = new TextBox();
            createRoomPanel = new Panel();
            backButton4 = new Label();
            postCreateRoom = new Button();
            roomPassBox = new TextBox();
            roomUsernameBox = new TextBox();
            joinRoomPanel = new Panel();
            backButton3 = new Label();
            getJoinRoomButton = new Button();
            joinRoomPasswordBox = new TextBox();
            joinRoomUsernameBox = new TextBox();
            viewRoomPanel = new Panel();
            backButton2 = new Label();
            roomPanel = new Panel();
            backButton = new Label();
            messagePanel = new Panel();
            sendButton = new Button();
            messageBox = new TextBox();
            roomNameLabel = new Label();
            messageUpdateTimer = new System.Windows.Forms.Timer(components);
            backButton6 = new Label();
            createAccountPanel.SuspendLayout();
            menuPanel.SuspendLayout();
            loggedInPanel.SuspendLayout();
            loggingInPanel.SuspendLayout();
            createRoomPanel.SuspendLayout();
            joinRoomPanel.SuspendLayout();
            viewRoomPanel.SuspendLayout();
            roomPanel.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 100F);
            label1.Location = new Point(60, 9);
            label1.Name = "label1";
            label1.Size = new Size(683, 177);
            label1.TabIndex = 0;
            label1.Text = "chat room";
            // 
            // loginButton
            // 
            loginButton.Location = new Point(191, 279);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(75, 23);
            loginButton.TabIndex = 1;
            loginButton.Text = "login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // createAccountButton
            // 
            createAccountButton.Location = new Point(548, 360);
            createAccountButton.Name = "createAccountButton";
            createAccountButton.Size = new Size(75, 23);
            createAccountButton.TabIndex = 2;
            createAccountButton.Text = "signup";
            createAccountButton.UseVisualStyleBackColor = true;
            createAccountButton.Click += createAccountButton_Click;
            // 
            // createAccountPanel
            // 
            createAccountPanel.Controls.Add(backButton5);
            createAccountPanel.Controls.Add(enterAccountCreation);
            createAccountPanel.Controls.Add(passwordBox);
            createAccountPanel.Controls.Add(usernameBox);
            createAccountPanel.Dock = DockStyle.Fill;
            createAccountPanel.Location = new Point(0, 0);
            createAccountPanel.Name = "createAccountPanel";
            createAccountPanel.Size = new Size(800, 450);
            createAccountPanel.TabIndex = 3;
            createAccountPanel.Visible = false;
            // 
            // backButton5
            // 
            backButton5.AutoSize = true;
            backButton5.Location = new Point(42, 26);
            backButton5.Name = "backButton5";
            backButton5.Size = new Size(14, 15);
            backButton5.TabIndex = 3;
            backButton5.Text = "X";
            backButton5.Click += backButton5_Click;
            // 
            // enterAccountCreation
            // 
            enterAccountCreation.Location = new Point(336, 298);
            enterAccountCreation.Name = "enterAccountCreation";
            enterAccountCreation.Size = new Size(75, 23);
            enterAccountCreation.TabIndex = 2;
            enterAccountCreation.Text = "create";
            enterAccountCreation.UseVisualStyleBackColor = true;
            enterAccountCreation.Click += enterAccountCreation_Click;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(328, 178);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(100, 23);
            passwordBox.TabIndex = 1;
            // 
            // usernameBox
            // 
            usernameBox.Location = new Point(328, 76);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(100, 23);
            usernameBox.TabIndex = 0;
            // 
            // menuPanel
            // 
            menuPanel.Controls.Add(createAccountButton);
            menuPanel.Controls.Add(loginButton);
            menuPanel.Controls.Add(label1);
            menuPanel.Dock = DockStyle.Fill;
            menuPanel.Location = new Point(0, 0);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(800, 450);
            menuPanel.TabIndex = 3;
            // 
            // loggedInPanel
            // 
            loggedInPanel.Controls.Add(logoutButton);
            loggedInPanel.Controls.Add(viewRoomsButton);
            loggedInPanel.Controls.Add(joinRoomButton);
            loggedInPanel.Controls.Add(createRoomButton);
            loggedInPanel.Controls.Add(label2);
            loggedInPanel.Dock = DockStyle.Fill;
            loggedInPanel.Location = new Point(0, 0);
            loggedInPanel.Name = "loggedInPanel";
            loggedInPanel.Size = new Size(800, 450);
            loggedInPanel.TabIndex = 3;
            // 
            // logoutButton
            // 
            logoutButton.AutoSize = true;
            logoutButton.Location = new Point(26, 21);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(42, 15);
            logoutButton.TabIndex = 4;
            logoutButton.Text = "logout";
            logoutButton.Click += logoutButton_Click;
            // 
            // viewRoomsButton
            // 
            viewRoomsButton.Location = new Point(346, 335);
            viewRoomsButton.Name = "viewRoomsButton";
            viewRoomsButton.Size = new Size(75, 23);
            viewRoomsButton.TabIndex = 3;
            viewRoomsButton.Text = "view room";
            viewRoomsButton.UseVisualStyleBackColor = true;
            viewRoomsButton.Click += viewRoomsButton_Click;
            // 
            // joinRoomButton
            // 
            joinRoomButton.Location = new Point(539, 241);
            joinRoomButton.Name = "joinRoomButton";
            joinRoomButton.Size = new Size(75, 23);
            joinRoomButton.TabIndex = 2;
            joinRoomButton.Text = "join room";
            joinRoomButton.UseVisualStyleBackColor = true;
            joinRoomButton.Click += joinRoomButton_Click;
            // 
            // createRoomButton
            // 
            createRoomButton.Location = new Point(146, 241);
            createRoomButton.Name = "createRoomButton";
            createRoomButton.Size = new Size(169, 23);
            createRoomButton.TabIndex = 1;
            createRoomButton.Text = "create room";
            createRoomButton.UseVisualStyleBackColor = true;
            createRoomButton.Click += createRoomButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(247, 46);
            label2.Name = "label2";
            label2.Size = new Size(284, 37);
            label2.TabIndex = 0;
            label2.Text = "you are now logged in";
            // 
            // loggingInPanel
            // 
            loggingInPanel.Controls.Add(backButton6);
            loggingInPanel.Controls.Add(logAccount);
            loggingInPanel.Controls.Add(logPassword);
            loggingInPanel.Controls.Add(logUsername);
            loggingInPanel.Dock = DockStyle.Fill;
            loggingInPanel.Location = new Point(0, 0);
            loggingInPanel.Name = "loggingInPanel";
            loggingInPanel.Size = new Size(800, 450);
            loggingInPanel.TabIndex = 0;
            // 
            // logAccount
            // 
            logAccount.Location = new Point(336, 327);
            logAccount.Name = "logAccount";
            logAccount.Size = new Size(75, 23);
            logAccount.TabIndex = 2;
            logAccount.Text = "login";
            logAccount.UseVisualStyleBackColor = true;
            logAccount.Click += logAccount_Click;
            // 
            // logPassword
            // 
            logPassword.Location = new Point(334, 219);
            logPassword.Name = "logPassword";
            logPassword.Size = new Size(100, 23);
            logPassword.TabIndex = 1;
            // 
            // logUsername
            // 
            logUsername.Location = new Point(334, 113);
            logUsername.Name = "logUsername";
            logUsername.Size = new Size(100, 23);
            logUsername.TabIndex = 0;
            // 
            // createRoomPanel
            // 
            createRoomPanel.Controls.Add(backButton4);
            createRoomPanel.Controls.Add(postCreateRoom);
            createRoomPanel.Controls.Add(roomPassBox);
            createRoomPanel.Controls.Add(roomUsernameBox);
            createRoomPanel.Dock = DockStyle.Fill;
            createRoomPanel.Location = new Point(0, 0);
            createRoomPanel.Name = "createRoomPanel";
            createRoomPanel.Size = new Size(800, 450);
            createRoomPanel.TabIndex = 4;
            // 
            // backButton4
            // 
            backButton4.AutoSize = true;
            backButton4.Location = new Point(27, 29);
            backButton4.Name = "backButton4";
            backButton4.Size = new Size(14, 15);
            backButton4.TabIndex = 2;
            backButton4.Text = "X";
            backButton4.Click += backButton4_Click;
            // 
            // postCreateRoom
            // 
            postCreateRoom.Location = new Point(367, 327);
            postCreateRoom.Name = "postCreateRoom";
            postCreateRoom.Size = new Size(75, 23);
            postCreateRoom.TabIndex = 0;
            postCreateRoom.Text = "create";
            postCreateRoom.Click += postCreateRoom_Click;
            // 
            // roomPassBox
            // 
            roomPassBox.Location = new Point(367, 219);
            roomPassBox.Name = "roomPassBox";
            roomPassBox.Size = new Size(100, 23);
            roomPassBox.TabIndex = 1;
            // 
            // roomUsernameBox
            // 
            roomUsernameBox.Location = new Point(367, 79);
            roomUsernameBox.Name = "roomUsernameBox";
            roomUsernameBox.Size = new Size(100, 23);
            roomUsernameBox.TabIndex = 0;
            // 
            // joinRoomPanel
            // 
            joinRoomPanel.Controls.Add(backButton3);
            joinRoomPanel.Controls.Add(getJoinRoomButton);
            joinRoomPanel.Controls.Add(joinRoomPasswordBox);
            joinRoomPanel.Controls.Add(joinRoomUsernameBox);
            joinRoomPanel.Dock = DockStyle.Fill;
            joinRoomPanel.Location = new Point(0, 0);
            joinRoomPanel.Name = "joinRoomPanel";
            joinRoomPanel.Size = new Size(800, 450);
            joinRoomPanel.TabIndex = 0;
            // 
            // backButton3
            // 
            backButton3.AutoSize = true;
            backButton3.Location = new Point(37, 16);
            backButton3.Name = "backButton3";
            backButton3.Size = new Size(14, 15);
            backButton3.TabIndex = 3;
            backButton3.Text = "X";
            backButton3.Click += backButton3_Click;
            // 
            // getJoinRoomButton
            // 
            getJoinRoomButton.Location = new Point(359, 335);
            getJoinRoomButton.Name = "getJoinRoomButton";
            getJoinRoomButton.Size = new Size(75, 23);
            getJoinRoomButton.TabIndex = 2;
            getJoinRoomButton.Text = "join";
            getJoinRoomButton.UseVisualStyleBackColor = true;
            getJoinRoomButton.Click += getJoinRoomButton_Click;
            // 
            // joinRoomPasswordBox
            // 
            joinRoomPasswordBox.Location = new Point(350, 214);
            joinRoomPasswordBox.Name = "joinRoomPasswordBox";
            joinRoomPasswordBox.Size = new Size(100, 23);
            joinRoomPasswordBox.TabIndex = 1;
            // 
            // joinRoomUsernameBox
            // 
            joinRoomUsernameBox.Location = new Point(351, 106);
            joinRoomUsernameBox.Name = "joinRoomUsernameBox";
            joinRoomUsernameBox.Size = new Size(100, 23);
            joinRoomUsernameBox.TabIndex = 0;
            // 
            // viewRoomPanel
            // 
            viewRoomPanel.Controls.Add(backButton2);
            viewRoomPanel.Dock = DockStyle.Fill;
            viewRoomPanel.Location = new Point(0, 0);
            viewRoomPanel.Name = "viewRoomPanel";
            viewRoomPanel.Size = new Size(800, 450);
            viewRoomPanel.TabIndex = 4;
            // 
            // backButton2
            // 
            backButton2.AutoSize = true;
            backButton2.Location = new Point(21, 24);
            backButton2.Name = "backButton2";
            backButton2.Size = new Size(14, 15);
            backButton2.TabIndex = 0;
            backButton2.Text = "X";
            backButton2.Click += backButton2_Click;
            // 
            // roomPanel
            // 
            roomPanel.Controls.Add(backButton);
            roomPanel.Controls.Add(messagePanel);
            roomPanel.Controls.Add(sendButton);
            roomPanel.Controls.Add(messageBox);
            roomPanel.Controls.Add(roomNameLabel);
            roomPanel.Dock = DockStyle.Fill;
            roomPanel.Location = new Point(0, 0);
            roomPanel.Name = "roomPanel";
            roomPanel.Size = new Size(800, 450);
            roomPanel.TabIndex = 0;
            // 
            // backButton
            // 
            backButton.AutoSize = true;
            backButton.Location = new Point(28, 22);
            backButton.Name = "backButton";
            backButton.Size = new Size(14, 15);
            backButton.TabIndex = 8;
            backButton.Text = "X";
            backButton.Click += backButton_Click;
            // 
            // messagePanel
            // 
            messagePanel.Location = new Point(156, 41);
            messagePanel.Name = "messagePanel";
            messagePanel.Size = new Size(488, 370);
            messagePanel.TabIndex = 7;
            // 
            // sendButton
            // 
            sendButton.Location = new Point(569, 417);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(75, 23);
            sendButton.TabIndex = 6;
            sendButton.Text = "send";
            sendButton.UseVisualStyleBackColor = true;
            sendButton.Click += sendButton_Click;
            // 
            // messageBox
            // 
            messageBox.Location = new Point(274, 417);
            messageBox.Name = "messageBox";
            messageBox.Size = new Size(275, 23);
            messageBox.TabIndex = 5;
            // 
            // roomNameLabel
            // 
            roomNameLabel.AutoSize = true;
            roomNameLabel.Font = new Font("Segoe UI", 40F);
            roomNameLabel.Location = new Point(156, -24);
            roomNameLabel.Name = "roomNameLabel";
            roomNameLabel.Size = new Size(315, 72);
            roomNameLabel.TabIndex = 4;
            roomNameLabel.Text = "room_name";
            // 
            // messageUpdateTimer
            // 
            messageUpdateTimer.Interval = 1000;
            messageUpdateTimer.Tick += messageUpdateTimer_Tick;
            // 
            // backButton6
            // 
            backButton6.AutoSize = true;
            backButton6.Location = new Point(28, 27);
            backButton6.Name = "backButton6";
            backButton6.Size = new Size(14, 15);
            backButton6.TabIndex = 3;
            backButton6.Text = "X";
            backButton6.Click += backButton6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(loggingInPanel);
            Controls.Add(joinRoomPanel);
            Controls.Add(createRoomPanel);
            Controls.Add(roomPanel);
            Controls.Add(viewRoomPanel);
            Controls.Add(loggedInPanel);
            Controls.Add(createAccountPanel);
            Controls.Add(menuPanel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            createAccountPanel.ResumeLayout(false);
            createAccountPanel.PerformLayout();
            menuPanel.ResumeLayout(false);
            menuPanel.PerformLayout();
            loggedInPanel.ResumeLayout(false);
            loggedInPanel.PerformLayout();
            loggingInPanel.ResumeLayout(false);
            loggingInPanel.PerformLayout();
            createRoomPanel.ResumeLayout(false);
            createRoomPanel.PerformLayout();
            joinRoomPanel.ResumeLayout(false);
            joinRoomPanel.PerformLayout();
            viewRoomPanel.ResumeLayout(false);
            viewRoomPanel.PerformLayout();
            roomPanel.ResumeLayout(false);
            roomPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button loginButton;
        private Button createAccountButton;
        private Panel createAccountPanel;
        private TextBox passwordBox;
        private TextBox usernameBox;
        private Button enterAccountCreation;
        private Panel menuPanel;
        private Panel loggedInPanel;
        private Panel loggingInPanel;
        private Button logAccount;
        private TextBox logPassword;
        private TextBox logUsername;
        private Button joinRoomButton;
        private Button createRoomButton;
        private Label label2;
        private Panel createRoomPanel;
        private Panel joinRoomPanel;
        private Button postCreateRoom;
        private TextBox roomPassBox;
        private TextBox roomUsernameBox;
        private Button viewRoomsButton;
        private Button getJoinRoomButton;
        private TextBox joinRoomPasswordBox;
        private TextBox joinRoomUsernameBox;
        private Panel viewRoomPanel;
        private Panel roomPanel;
        private Panel messagePanel;
        private Button sendButton;
        private TextBox messageBox;
        private Label roomNameLabel;
        private System.Windows.Forms.Timer messageUpdateTimer;
        private Label backButton;
        private Label backButton2;
        private Label logoutButton;
        private Label backButton3;
        private Label backButton4;
        private Label backButton5;
        private Label backButton6;
    }
}
