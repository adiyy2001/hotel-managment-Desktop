
namespace Hotel_managment.all_user_control
{
    partial class UC_Employee
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2HtmlLabel13 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tabEmployees = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.registerButton = new Guna.UI2.WinForms.Guna2Button();
            this.passwordV = new System.Windows.Forms.Label();
            this.password = new Guna.UI2.WinForms.Guna2TextBox();
            this.username = new Guna.UI2.WinForms.Guna2TextBox();
            this.usernameV = new System.Windows.Forms.Label();
            this.gender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.name = new Guna.UI2.WinForms.Guna2TextBox();
            this.mobileNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.email = new Guna.UI2.WinForms.Guna2TextBox();
            this.emailId = new System.Windows.Forms.Label();
            this.genderType = new System.Windows.Forms.Label();
            this.mobileNumber = new System.Windows.Forms.Label();
            this.primaryName = new System.Windows.Forms.Label();
            this.labelToSet = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.guna2DataGridView2 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.guna2DataGridView3 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.deleteButton = new Guna.UI2.WinForms.Guna2Button();
            this.EmployeeId = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabEmployees.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2HtmlLabel13
            // 
            this.guna2HtmlLabel13.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel13.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.guna2HtmlLabel13.Location = new System.Drawing.Point(41, 38);
            this.guna2HtmlLabel13.Name = "guna2HtmlLabel13";
            this.guna2HtmlLabel13.Size = new System.Drawing.Size(93, 26);
            this.guna2HtmlLabel13.TabIndex = 25;
            this.guna2HtmlLabel13.Text = "Emplyee";
            // 
            // tabEmployees
            // 
            this.tabEmployees.Controls.Add(this.tabPage1);
            this.tabEmployees.Controls.Add(this.tabPage2);
            this.tabEmployees.Controls.Add(this.tabPage3);
            this.tabEmployees.Location = new System.Drawing.Point(41, 93);
            this.tabEmployees.Name = "tabEmployees";
            this.tabEmployees.SelectedIndex = 0;
            this.tabEmployees.Size = new System.Drawing.Size(1302, 430);
            this.tabEmployees.TabIndex = 26;
            this.tabEmployees.SelectedIndexChanged += new System.EventHandler(this.tabEmployees_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.registerButton);
            this.tabPage1.Controls.Add(this.passwordV);
            this.tabPage1.Controls.Add(this.password);
            this.tabPage1.Controls.Add(this.username);
            this.tabPage1.Controls.Add(this.usernameV);
            this.tabPage1.Controls.Add(this.gender);
            this.tabPage1.Controls.Add(this.name);
            this.tabPage1.Controls.Add(this.mobileNo);
            this.tabPage1.Controls.Add(this.email);
            this.tabPage1.Controls.Add(this.emailId);
            this.tabPage1.Controls.Add(this.genderType);
            this.tabPage1.Controls.Add(this.mobileNumber);
            this.tabPage1.Controls.Add(this.primaryName);
            this.tabPage1.Controls.Add(this.labelToSet);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1294, 404);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Employee Registration";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // registerButton
            // 
            this.registerButton.BorderRadius = 30;
            this.registerButton.BorderThickness = 1;
            this.registerButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.registerButton.CheckedState.Parent = this.registerButton;
            this.registerButton.CustomImages.Parent = this.registerButton;
            this.registerButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.registerButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.registerButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.registerButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.registerButton.DisabledState.Parent = this.registerButton;
            this.registerButton.FillColor = System.Drawing.Color.White;
            this.registerButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.registerButton.ForeColor = System.Drawing.Color.Black;
            this.registerButton.HoverState.Parent = this.registerButton;
            this.registerButton.Location = new System.Drawing.Point(839, 288);
            this.registerButton.Name = "registerButton";
            this.registerButton.ShadowDecoration.Parent = this.registerButton;
            this.registerButton.Size = new System.Drawing.Size(180, 45);
            this.registerButton.TabIndex = 16;
            this.registerButton.Text = "Register";
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // passwordV
            // 
            this.passwordV.AutoSize = true;
            this.passwordV.Location = new System.Drawing.Point(684, 182);
            this.passwordV.Name = "passwordV";
            this.passwordV.Size = new System.Drawing.Size(82, 21);
            this.passwordV.TabIndex = 15;
            this.passwordV.Text = "Password";
            // 
            // password
            // 
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.DefaultText = "";
            this.password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password.DisabledState.Parent = this.password;
            this.password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.password.FocusedState.Parent = this.password;
            this.password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.password.HoverState.Parent = this.password;
            this.password.Location = new System.Drawing.Point(688, 206);
            this.password.Name = "password";
            this.password.PasswordChar = '\0';
            this.password.PlaceholderText = "";
            this.password.SelectedText = "";
            this.password.ShadowDecoration.Parent = this.password;
            this.password.Size = new System.Drawing.Size(331, 36);
            this.password.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.password.TabIndex = 14;
            // 
            // username
            // 
            this.username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username.DefaultText = "";
            this.username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username.DisabledState.Parent = this.username;
            this.username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.username.FocusedState.Parent = this.username;
            this.username.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.username.HoverState.Parent = this.username;
            this.username.Location = new System.Drawing.Point(688, 113);
            this.username.Name = "username";
            this.username.PasswordChar = '\0';
            this.username.PlaceholderText = "";
            this.username.SelectedText = "";
            this.username.ShadowDecoration.Parent = this.username;
            this.username.Size = new System.Drawing.Size(331, 36);
            this.username.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.username.TabIndex = 13;
            // 
            // usernameV
            // 
            this.usernameV.AutoSize = true;
            this.usernameV.Location = new System.Drawing.Point(684, 88);
            this.usernameV.Name = "usernameV";
            this.usernameV.Size = new System.Drawing.Size(94, 21);
            this.usernameV.TabIndex = 12;
            this.usernameV.Text = "User Name";
            // 
            // gender
            // 
            this.gender.BackColor = System.Drawing.Color.Transparent;
            this.gender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gender.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gender.FocusedState.Parent = this.gender;
            this.gender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.gender.HoverState.Parent = this.gender;
            this.gender.ItemHeight = 30;
            this.gender.Items.AddRange(new object[] {
            "male ",
            "female ",
            "other"});
            this.gender.ItemsAppearance.Parent = this.gender;
            this.gender.Location = new System.Drawing.Point(62, 254);
            this.gender.Name = "gender";
            this.gender.ShadowDecoration.Parent = this.gender;
            this.gender.Size = new System.Drawing.Size(331, 36);
            this.gender.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.gender.TabIndex = 11;
            // 
            // name
            // 
            this.name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name.DefaultText = "";
            this.name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.name.DisabledState.Parent = this.name;
            this.name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.name.FocusedState.Parent = this.name;
            this.name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.name.HoverState.Parent = this.name;
            this.name.Location = new System.Drawing.Point(62, 113);
            this.name.Name = "name";
            this.name.PasswordChar = '\0';
            this.name.PlaceholderText = "";
            this.name.SelectedText = "";
            this.name.ShadowDecoration.Parent = this.name;
            this.name.Size = new System.Drawing.Size(331, 36);
            this.name.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.name.TabIndex = 9;
            // 
            // mobileNo
            // 
            this.mobileNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mobileNo.DefaultText = "";
            this.mobileNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.mobileNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.mobileNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mobileNo.DisabledState.Parent = this.mobileNo;
            this.mobileNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mobileNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mobileNo.FocusedState.Parent = this.mobileNo;
            this.mobileNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mobileNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mobileNo.HoverState.Parent = this.mobileNo;
            this.mobileNo.Location = new System.Drawing.Point(62, 176);
            this.mobileNo.Name = "mobileNo";
            this.mobileNo.PasswordChar = '\0';
            this.mobileNo.PlaceholderText = "";
            this.mobileNo.SelectedText = "";
            this.mobileNo.ShadowDecoration.Parent = this.mobileNo;
            this.mobileNo.Size = new System.Drawing.Size(331, 36);
            this.mobileNo.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.mobileNo.TabIndex = 8;
            // 
            // email
            // 
            this.email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email.DefaultText = "";
            this.email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.email.DisabledState.Parent = this.email;
            this.email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.email.FocusedState.Parent = this.email;
            this.email.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.email.HoverState.Parent = this.email;
            this.email.Location = new System.Drawing.Point(62, 336);
            this.email.Name = "email";
            this.email.PasswordChar = '\0';
            this.email.PlaceholderText = "";
            this.email.SelectedText = "";
            this.email.ShadowDecoration.Parent = this.email;
            this.email.Size = new System.Drawing.Size(331, 36);
            this.email.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.email.TabIndex = 6;
            // 
            // emailId
            // 
            this.emailId.AutoSize = true;
            this.emailId.Location = new System.Drawing.Point(58, 312);
            this.emailId.Name = "emailId";
            this.emailId.Size = new System.Drawing.Size(71, 21);
            this.emailId.TabIndex = 5;
            this.emailId.Text = "Email Id";
            // 
            // genderType
            // 
            this.genderType.AutoSize = true;
            this.genderType.Location = new System.Drawing.Point(58, 230);
            this.genderType.Name = "genderType";
            this.genderType.Size = new System.Drawing.Size(70, 21);
            this.genderType.TabIndex = 4;
            this.genderType.Text = "Gender";
            // 
            // mobileNumber
            // 
            this.mobileNumber.AutoSize = true;
            this.mobileNumber.Location = new System.Drawing.Point(58, 152);
            this.mobileNumber.Name = "mobileNumber";
            this.mobileNumber.Size = new System.Drawing.Size(88, 21);
            this.mobileNumber.TabIndex = 3;
            this.mobileNumber.Text = "Mobile No";
            // 
            // primaryName
            // 
            this.primaryName.AutoSize = true;
            this.primaryName.Location = new System.Drawing.Point(58, 88);
            this.primaryName.Name = "primaryName";
            this.primaryName.Size = new System.Drawing.Size(58, 21);
            this.primaryName.TabIndex = 2;
            this.primaryName.Text = "Name";
            // 
            // labelToSet
            // 
            this.labelToSet.AutoSize = true;
            this.labelToSet.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelToSet.ForeColor = System.Drawing.Color.Red;
            this.labelToSet.Location = new System.Drawing.Point(100, 16);
            this.labelToSet.Name = "labelToSet";
            this.labelToSet.Size = new System.Drawing.Size(37, 30);
            this.labelToSet.TabIndex = 1;
            this.labelToSet.Text = "---";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID -";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.guna2DataGridView2);
            this.tabPage2.Controls.Add(this.guna2DataGridView1);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1294, 404);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Employee Details";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // guna2DataGridView2
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.guna2DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2DataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView2.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView2.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView2.EnableHeadersVisualStyles = false;
            this.guna2DataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView2.Location = new System.Drawing.Point(48, 114);
            this.guna2DataGridView2.Name = "guna2DataGridView2";
            this.guna2DataGridView2.RowHeadersVisible = false;
            this.guna2DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridView2.Size = new System.Drawing.Size(1220, 209);
            this.guna2DataGridView2.TabIndex = 3;
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView2.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView2.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.Height = 4;
            this.guna2DataGridView2.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView2.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView2.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView2.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.guna2DataGridView2.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView2.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView2.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView2.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // this.guna2DataGridView2.SelectionChanged += new System.EventHandler(this.guna2DataGridView2_SelectionChanged);
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.guna2DataGridView1.ColumnHeadersHeight = 4;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.guna2DataGridView1.EnableHeadersVisualStyles = false;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(48, 114);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridView1.Size = new System.Drawing.Size(1220, 264);
            this.guna2DataGridView1.TabIndex = 2;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(506, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(243, 33);
            this.label9.TabIndex = 1;
            this.label9.Text = "Employee Details";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.guna2DataGridView3);
            this.tabPage3.Controls.Add(this.deleteButton);
            this.tabPage3.Controls.Add(this.EmployeeId);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1294, 404);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Delete Employee";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // guna2DataGridView3
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView3.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.guna2DataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridView3.BackgroundColor = System.Drawing.Color.White;
            this.guna2DataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2DataGridView3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.guna2DataGridView3.ColumnHeadersHeight = 4;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView3.DefaultCellStyle = dataGridViewCellStyle9;
            this.guna2DataGridView3.EnableHeadersVisualStyles = false;
            this.guna2DataGridView3.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView3.Location = new System.Drawing.Point(27, 214);
            this.guna2DataGridView3.Name = "guna2DataGridView3";
            this.guna2DataGridView3.RowHeadersVisible = false;
            this.guna2DataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridView3.Size = new System.Drawing.Size(1241, 150);
            this.guna2DataGridView3.TabIndex = 18;
            this.guna2DataGridView3.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView3.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView3.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView3.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView3.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView3.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView3.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView3.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView3.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView3.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.guna2DataGridView3.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView3.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView3.ThemeStyle.HeaderStyle.Height = 4;
            this.guna2DataGridView3.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView3.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView3.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView3.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.guna2DataGridView3.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView3.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView3.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView3.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // deleteButton
            // 
            this.deleteButton.BorderRadius = 30;
            this.deleteButton.BorderThickness = 1;
            this.deleteButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.deleteButton.CheckedState.Parent = this.deleteButton;
            this.deleteButton.CustomImages.Parent = this.deleteButton;
            this.deleteButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deleteButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deleteButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deleteButton.DisabledState.Parent = this.deleteButton;
            this.deleteButton.FillColor = System.Drawing.Color.White;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.deleteButton.ForeColor = System.Drawing.Color.Black;
            this.deleteButton.HoverState.Parent = this.deleteButton;
            this.deleteButton.Location = new System.Drawing.Point(534, 143);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.ShadowDecoration.Parent = this.deleteButton;
            this.deleteButton.Size = new System.Drawing.Size(180, 45);
            this.deleteButton.TabIndex = 17;
            this.deleteButton.Text = "Delete";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // EmployeeId
            // 
            this.EmployeeId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmployeeId.DefaultText = "";
            this.EmployeeId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EmployeeId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EmployeeId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmployeeId.DisabledState.Parent = this.EmployeeId;
            this.EmployeeId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmployeeId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmployeeId.FocusedState.Parent = this.EmployeeId;
            this.EmployeeId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EmployeeId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmployeeId.HoverState.Parent = this.EmployeeId;
            this.EmployeeId.Location = new System.Drawing.Point(514, 71);
            this.EmployeeId.Name = "EmployeeId";
            this.EmployeeId.PasswordChar = '\0';
            this.EmployeeId.PlaceholderText = "Enter Id";
            this.EmployeeId.SelectedText = "";
            this.EmployeeId.ShadowDecoration.Parent = this.EmployeeId;
            this.EmployeeId.Size = new System.Drawing.Size(200, 36);
            this.EmployeeId.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.EmployeeId.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(510, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 21);
            this.label10.TabIndex = 0;
            this.label10.Text = "ID";
            // 
            // UC_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabEmployees);
            this.Controls.Add(this.guna2HtmlLabel13);
            this.Name = "UC_Employee";
            this.Size = new System.Drawing.Size(1617, 583);
            this.Load += new System.EventHandler(this.UC_Employee_Load);
            this.Leave += new System.EventHandler(this.UC_Employee_Leave);
            this.tabEmployees.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.TabControl tabEmployees;
        private System.Windows.Forms.TabPage tabPage1;
        private Guna.UI2.WinForms.Guna2ComboBox gender;
        private Guna.UI2.WinForms.Guna2TextBox name;
        private Guna.UI2.WinForms.Guna2TextBox mobileNo;
        private Guna.UI2.WinForms.Guna2TextBox email;
        private System.Windows.Forms.Label emailId;
        private System.Windows.Forms.Label genderType;
        private System.Windows.Forms.Label mobileNumber;
        private System.Windows.Forms.Label primaryName;
        private System.Windows.Forms.Label labelToSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel13;
        private Guna.UI2.WinForms.Guna2Button registerButton;
        private System.Windows.Forms.Label passwordV;
        private Guna.UI2.WinForms.Guna2TextBox password;
        private Guna.UI2.WinForms.Guna2TextBox username;
        private System.Windows.Forms.Label usernameV;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView2;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView3;
        private Guna.UI2.WinForms.Guna2Button deleteButton;
        private Guna.UI2.WinForms.Guna2TextBox EmployeeId;
        private System.Windows.Forms.Label label10;
    }
}
