namespace anket_2
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
            panel1 = new Panel();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            add_btn = new Button();
            change_btn = new Button();
            dateTimePicker1 = new DateTimePicker();
            birthday_lbl = new Label();
            tel_lbl = new Label();
            email_lbl = new Label();
            surname_lbl = new Label();
            name_lbl = new Label();
            label1 = new Label();
            users_listbox = new ListBox();
            load_btn = new Button();
            save_btn = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(55, 56, 78);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(add_btn);
            panel1.Controls.Add(change_btn);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(birthday_lbl);
            panel1.Controls.Add(tel_lbl);
            panel1.Controls.Add(email_lbl);
            panel1.Controls.Add(surname_lbl);
            panel1.Controls.Add(name_lbl);
            panel1.Location = new Point(12, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(496, 378);
            panel1.TabIndex = 0;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(157, 184);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(200, 23);
            textBox4.TabIndex = 15;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(157, 136);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 23);
            textBox3.TabIndex = 14;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(156, 92);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 23);
            textBox2.TabIndex = 13;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(156, 51);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 12;
            // 
            // add_btn
            // 
            add_btn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            add_btn.ForeColor = SystemColors.ActiveCaptionText;
            add_btn.Location = new Point(358, 322);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(116, 44);
            add_btn.TabIndex = 11;
            add_btn.Text = "Add";
            add_btn.UseVisualStyleBackColor = true;
            add_btn.Click += add_btn_Click;
            // 
            // change_btn
            // 
            change_btn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            change_btn.ForeColor = SystemColors.ActiveCaptionText;
            change_btn.Location = new Point(358, 272);
            change_btn.Name = "change_btn";
            change_btn.Size = new Size(116, 44);
            change_btn.TabIndex = 10;
            change_btn.Text = "Change";
            change_btn.UseVisualStyleBackColor = true;
            change_btn.Click += change_btn_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(156, 228);
            dateTimePicker1.MaxDate = new DateTime(2009, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(1971, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 9;
            dateTimePicker1.Value = new DateTime(2009, 1, 1, 0, 0, 0, 0);
            // 
            // birthday_lbl
            // 
            birthday_lbl.AutoSize = true;
            birthday_lbl.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            birthday_lbl.ForeColor = SystemColors.Control;
            birthday_lbl.Location = new Point(29, 220);
            birthday_lbl.Name = "birthday_lbl";
            birthday_lbl.Size = new Size(99, 31);
            birthday_lbl.TabIndex = 7;
            birthday_lbl.Text = "Birthday";
            // 
            // tel_lbl
            // 
            tel_lbl.AutoSize = true;
            tel_lbl.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            tel_lbl.ForeColor = SystemColors.Control;
            tel_lbl.Location = new Point(29, 176);
            tel_lbl.Name = "tel_lbl";
            tel_lbl.Size = new Size(119, 31);
            tel_lbl.TabIndex = 6;
            tel_lbl.Text = "Telephone";
            // 
            // email_lbl
            // 
            email_lbl.AutoSize = true;
            email_lbl.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            email_lbl.ForeColor = SystemColors.Control;
            email_lbl.Location = new Point(29, 128);
            email_lbl.Name = "email_lbl";
            email_lbl.Size = new Size(70, 31);
            email_lbl.TabIndex = 4;
            email_lbl.Text = "Email";
            // 
            // surname_lbl
            // 
            surname_lbl.AutoSize = true;
            surname_lbl.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            surname_lbl.ForeColor = SystemColors.Control;
            surname_lbl.Location = new Point(29, 84);
            surname_lbl.Name = "surname_lbl";
            surname_lbl.Size = new Size(104, 31);
            surname_lbl.TabIndex = 2;
            surname_lbl.Text = "Surname";
            // 
            // name_lbl
            // 
            name_lbl.AutoSize = true;
            name_lbl.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            name_lbl.ForeColor = SystemColors.Control;
            name_lbl.Location = new Point(29, 43);
            name_lbl.Name = "name_lbl";
            name_lbl.Size = new Size(75, 31);
            name_lbl.TabIndex = 0;
            name_lbl.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(55, 56, 78);
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(29, 27);
            label1.Name = "label1";
            label1.Size = new Size(131, 25);
            label1.TabIndex = 12;
            label1.Text = "Questionnarie";
            // 
            // users_listbox
            // 
            users_listbox.BackColor = Color.FromArgb(55, 56, 78);
            users_listbox.ForeColor = SystemColors.Window;
            users_listbox.FormattingEnabled = true;
            users_listbox.ItemHeight = 15;
            users_listbox.Location = new Point(534, 42);
            users_listbox.Name = "users_listbox";
            users_listbox.Size = new Size(215, 334);
            users_listbox.TabIndex = 1;
            // 
            // load_btn
            // 
            load_btn.BackColor = Color.FromArgb(55, 56, 78);
            load_btn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            load_btn.ForeColor = SystemColors.Control;
            load_btn.Location = new Point(534, 383);
            load_btn.Name = "load_btn";
            load_btn.Size = new Size(99, 37);
            load_btn.TabIndex = 12;
            load_btn.Text = "Load";
            load_btn.UseVisualStyleBackColor = false;
            load_btn.Click += load_btn_Click;
            // 
            // save_btn
            // 
            save_btn.BackColor = Color.FromArgb(55, 56, 78);
            save_btn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            save_btn.ForeColor = SystemColors.Control;
            save_btn.Location = new Point(639, 383);
            save_btn.Name = "save_btn";
            save_btn.Size = new Size(99, 37);
            save_btn.TabIndex = 13;
            save_btn.Text = "Save";
            save_btn.UseVisualStyleBackColor = false;
            save_btn.Click += save_btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(766, 427);
            Controls.Add(save_btn);
            Controls.Add(load_btn);
            Controls.Add(label1);
            Controls.Add(users_listbox);
            Controls.Add(panel1);
            ForeColor = SystemColors.Control;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label surname_lbl;
        private Label name_lbl;
        private Label email_lbl;
        private DateTimePicker dateTimePicker1;
        private Label birthday_lbl;
        private Label tel_lbl;
        private Button add_btn;
        private Button change_btn;
        private ListBox users_listbox;
        private Label label1;
        private Button load_btn;
        private Button save_btn;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}