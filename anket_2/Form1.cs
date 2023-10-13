#nullable disable

namespace anket_2
{
    public partial class Form1 : Form
    {
        DataBase database1 = new();
        public Form1()
        {
            InitializeComponent();
            textBox3.ReadOnly = false;
            database1.program_start();
            List<string> info = new();
            foreach (var user in database1.users)
                info.Add(user.ToString());
            users_listbox.DataSource = null;
            users_listbox.DataSource = info;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && textBox3.Text.Length > 0 && textBox4.Text.Length > 0)
            {
                foreach (var user in database1.users)
                {
                    if (user.Email == textBox3.Text)
                    {
                        MessageBox.Show("Email Has Been Taken. Try new One");
                        textBox3.Text = "";
                        continue;
                    }
                }
                User new_user = new(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, dateTimePicker1.Value);
                database1.users.Add(new_user);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                dateTimePicker1.Value = dateTimePicker1.MaxDate;
                List<string> info = new();
                foreach (var user in database1.users)
                    info.Add(user.ToString());
                users_listbox.DataSource = null;
                users_listbox.DataSource = info;
            }
            else
                MessageBox.Show("All Information Must be Completed");
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            database1.write();
        }

        private void load_btn_Click(object sender, EventArgs e)
        {
            textBox3.ReadOnly = true;
            users_listbox.SelectionMode = SelectionMode.One;
            string email = users_listbox.SelectedItem.ToString();
            User current_user = database1.users.Find(user => user.Email == email);
            textBox1.Text = current_user.Name;
            textBox2.Text = current_user.Surname;
            textBox3.Text = current_user.Email;
            textBox4.Text = current_user.Phone;
            dateTimePicker1.Value = current_user.birthdate;
        }

        private void change_btn_Click(object sender, EventArgs e)
        {
            User current_user = database1.users.Find(user => user.Email == textBox3.Text);
            current_user.Name = textBox1.Text;
            current_user.Surname = textBox2.Text;
            current_user.Phone = textBox4.Text;
            current_user.birthdate = dateTimePicker1.Value;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            dateTimePicker1.Value = dateTimePicker1.MaxDate;
            textBox3.ReadOnly = false;
        }
    }
}