using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace Orgteh
{
    public partial class Authorization : Form
    {
        DB dataBase = new DB();

        public static int userID;
        public static string lvl = null;

        private bool showpass = true;
        private bool reloadapp = false;
        private string captchat = null;
        private int failenters = 0;
        private int counttimer = 3;
        public static string name = null;
        public static string surname = null;
        public Authorization()
        {
            InitializeComponent();
            textBoxpass.PasswordChar = '*';
            textBoxLogin.MaxLength = 25;
            textBoxpass.MaxLength = 25;
            this.StartPosition = FormStartPosition.CenterScreen;
            timerEnter.Interval = 1000;
        }

        public void buttonLogin_Click(object sender, EventArgs e)
        {
            if (reloadapp)
            {
                Application.Restart();
            }
            string login = textBoxLogin.Text;
            string password = textBoxpass.Text;
            if (login == "" || password == "")
            {
                MessageBox.Show("Укажите логин и пароль для входа.");
                return;
            }
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            string query = "SELECT userID, fio, lvl FROM Users WHERE login = @login AND password = @password";

            SqlCommand sqlCommand = new SqlCommand(query, dataBase.GetConnection());
            sqlCommand.Parameters.AddWithValue("@login", login);
            sqlCommand.Parameters.AddWithValue("@password", password);

            adapter.SelectCommand = sqlCommand;
            try
            {
                adapter.Fill(dt);
            }
            catch (Exception)
            {
                MessageBox.Show("Не удалось подключиться к базе данных!");
                return;
            }

            if (panelсaptch.Visible == true)
            {
                if (textBoxCaptcha.Text != captchat)
                {
                    MessageBox.Show("Неверный код капчи! Попробуйте ещё раз.");
                    return;
                }
            }
            if (dt.Rows.Count == 1)
            {

                Savelog(login, true);
                 string[] arrFio = dt.Rows[0]["fio"].ToString().Split();
                name = arrFio[1];
                surname = arrFio[0];
                lvl = dt.Rows[0]["lvl"].ToString();
                userID = Convert.ToInt32(dt.Rows[0]["userID"]);
                MessageBox.Show($"Добро пожаловать {name} {surname}!\nВы зашли как {lvl}");
                Form MainForm = new Form();
                switch (lvl)
                {
                    case "Клиент": MainForm = new ClientForm(); break;
                    case "Мастер": MainForm = new MasterForm(); break;
                    case "Оператор": MainForm = new OperatorForm(); break;
                }
                this.Hide();
                MainForm.ShowDialog();
            }

            else
            {
                failenters = failenters + 1;
                Savelog(login, false);
                FailEnter();
            }
        }

        public void Savelog(string login, bool enterstatus)
        {
            dataBase.OpenConnection();
            string query = "INSERT INTO Logs (entertime, userlogin, enterstatus) " +
                           "VALUES (@entertime, @userlogin, @enterstatus)";
            SqlCommand command = new SqlCommand(query, dataBase.GetConnection());
            command.Parameters.AddWithValue("@entertime", DateTime.Now);
            command.Parameters.AddWithValue("@userlogin", login);
            command.Parameters.AddWithValue("@enterstatus", enterstatus ? 1 : 0);

            command.ExecuteNonQuery();
            dataBase.CloseConnection();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (showpass)
            {
                textBoxpass.PasswordChar = '*';
            }

            else
            {
                textBoxpass.PasswordChar = '\0';
            }
            showpass = !showpass;
        }
        private void FailEnter()
        {
            if (failenters == 2)
            {
                timerEnter.Start();
                buttonEnter.Enabled = false;
            }
            else if (failenters == 3)
            {
                reloadapp = true;
                buttonEnter.Text = "Требуется перезапуск";
            }

            MessageBox.Show("Неправильно введён логин или пароль!");
            textBoxLogin.Text = null;
            textBoxpass.Text = null;
            panelсaptch.Visible = true;
            pictureBox1.Image = CreateImage(pictureBox1.Width, pictureBox1.Height);
        }
        private Bitmap CreateImage(int Width, int Height)
        {
            Random rnd = new Random();

            Bitmap result = new Bitmap(Width, Height);

            int Xpos = rnd.Next(0, Width - 70);
            int Ypos = rnd.Next(0, Height - 15);

            Brush[] colors = { Brushes.Black,
                     Brushes.Red,
                     Brushes.RoyalBlue,
                     Brushes.Green };

            Graphics g = Graphics.FromImage(result);

            g.Clear(Color.Gray);

            captchat = null;
            string ALF = "1234567890QWERTYUIOPASDFGHJKLZXCVBNM";
            for (int i = 0; i < 5; ++i)
                captchat += ALF[rnd.Next(ALF.Length)];

            g.DrawString(captchat, new Font("Arial", 15), colors[rnd.Next(colors.Length)], new PointF(Xpos, Ypos));
            g.DrawLine(Pens.Black, new Point(0, 0), new Point(Width - 1, Height - 1));
            g.DrawLine(Pens.Black, new Point(0, Height - 1), new Point(Width - 1, 0));

            for (int i = 0; i < Width; ++i)
                for (int j = 0; j < Height; ++j)
                    if (rnd.Next() % 20 == 0)
                        result.SetPixel(i, j, Color.White);

            return result;
        }

        private void buttonNewCaptcha_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = CreateImage(pictureBox1.Width, pictureBox1.Height);
        }

        private void timerEnter_Tick(object sender, EventArgs e)
        {
            if (counttimer >= 0)
            {
                buttonEnter.Text = counttimer.ToString();
                counttimer--;
            }

            if (counttimer < 0)
            {
                timerEnter.Stop();
                buttonEnter.Enabled = true;
                buttonEnter.Text = "Вход";
            }
        }

        private void Authorization_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}