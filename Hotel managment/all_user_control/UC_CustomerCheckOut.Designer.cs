
namespace Hotel_managment.all_user_control
{
    partial class UC_CustomerCheckOut
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2HtmlLabel13 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.name = new Guna.UI2.WinForms.Guna2TextBox();
            this.customerCheckoutBoard = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Cname = new Guna.UI2.WinForms.Guna2TextBox();
            this.roomNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.checkOutDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnCheckOut = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.customerCheckoutBoard)).BeginInit();
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
            this.guna2HtmlLabel13.Location = new System.Drawing.Point(50, 26);
            this.guna2HtmlLabel13.Name = "guna2HtmlLabel13";
            this.guna2HtmlLabel13.Size = new System.Drawing.Size(212, 26);
            this.guna2HtmlLabel13.TabIndex = 25;
            this.guna2HtmlLabel13.Text = "Customer Checkout";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(423, 73);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(45, 22);
            this.guna2HtmlLabel3.TabIndex = 28;
            this.guna2HtmlLabel3.Text = "name";
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
            this.name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.name.HoverState.Parent = this.name;
            this.name.Location = new System.Drawing.Point(423, 102);
            this.name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.name.Name = "name";
            this.name.PasswordChar = '\0';
            this.name.PlaceholderText = "Enter full name";
            this.name.SelectedText = "";
            this.name.ShadowDecoration.Parent = this.name;
            this.name.Size = new System.Drawing.Size(257, 50);
            this.name.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.name.TabIndex = 29;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // customerCheckoutBoard
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.customerCheckoutBoard.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.customerCheckoutBoard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customerCheckoutBoard.BackgroundColor = System.Drawing.Color.White;
            this.customerCheckoutBoard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.customerCheckoutBoard.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.customerCheckoutBoard.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerCheckoutBoard.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.customerCheckoutBoard.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.customerCheckoutBoard.DefaultCellStyle = dataGridViewCellStyle3;
            this.customerCheckoutBoard.EnableHeadersVisualStyles = false;
            this.customerCheckoutBoard.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.customerCheckoutBoard.Location = new System.Drawing.Point(50, 168);
            this.customerCheckoutBoard.Name = "customerCheckoutBoard";
            this.customerCheckoutBoard.RowHeadersVisible = false;
            this.customerCheckoutBoard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerCheckoutBoard.Size = new System.Drawing.Size(1139, 224);
            this.customerCheckoutBoard.TabIndex = 32;
            this.customerCheckoutBoard.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.customerCheckoutBoard.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.customerCheckoutBoard.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.customerCheckoutBoard.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.customerCheckoutBoard.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.customerCheckoutBoard.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.customerCheckoutBoard.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.customerCheckoutBoard.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.customerCheckoutBoard.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.customerCheckoutBoard.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.customerCheckoutBoard.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.customerCheckoutBoard.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.customerCheckoutBoard.ThemeStyle.HeaderStyle.Height = 4;
            this.customerCheckoutBoard.ThemeStyle.ReadOnly = false;
            this.customerCheckoutBoard.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.customerCheckoutBoard.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.customerCheckoutBoard.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.customerCheckoutBoard.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.customerCheckoutBoard.ThemeStyle.RowsStyle.Height = 22;
            this.customerCheckoutBoard.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.customerCheckoutBoard.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // this.customerCheckoutBoard.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView3_CellContentClick);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(50, 414);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(45, 22);
            this.guna2HtmlLabel1.TabIndex = 33;
            this.guna2HtmlLabel1.Text = "name";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(423, 414);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(70, 22);
            this.guna2HtmlLabel2.TabIndex = 34;
            this.guna2HtmlLabel2.Text = "Room No";
            // 
            // Cname
            // 
            this.Cname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Cname.DefaultText = "";
            this.Cname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Cname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Cname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Cname.DisabledState.Parent = this.Cname;
            this.Cname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Cname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Cname.FocusedState.Parent = this.Cname;
            this.Cname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Cname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Cname.HoverState.Parent = this.Cname;
            this.Cname.Location = new System.Drawing.Point(50, 443);
            this.Cname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cname.Name = "Cname";
            this.Cname.PasswordChar = '\0';
            this.Cname.PlaceholderText = "Enter full name";
            this.Cname.SelectedText = "";
            this.Cname.ShadowDecoration.Parent = this.Cname;
            this.Cname.Size = new System.Drawing.Size(257, 50);
            this.Cname.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.Cname.TabIndex = 35;
            // 
            // roomNo
            // 
            this.roomNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.roomNo.DefaultText = "";
            this.roomNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.roomNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.roomNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.roomNo.DisabledState.Parent = this.roomNo;
            this.roomNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.roomNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roomNo.FocusedState.Parent = this.roomNo;
            this.roomNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.roomNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roomNo.HoverState.Parent = this.roomNo;
            this.roomNo.Location = new System.Drawing.Point(423, 443);
            this.roomNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.roomNo.Name = "roomNo";
            this.roomNo.PasswordChar = '\0';
            this.roomNo.PlaceholderText = "Room No";
            this.roomNo.SelectedText = "";
            this.roomNo.ShadowDecoration.Parent = this.roomNo;
            this.roomNo.Size = new System.Drawing.Size(257, 50);
            this.roomNo.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.roomNo.TabIndex = 36;
            // 
            // checkOutDate
            // 
            this.checkOutDate.CheckedState.Parent = this.checkOutDate;
            this.checkOutDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkOutDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.checkOutDate.HoverState.Parent = this.checkOutDate;
            this.checkOutDate.Location = new System.Drawing.Point(730, 457);
            this.checkOutDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.checkOutDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.checkOutDate.Name = "checkOutDate";
            this.checkOutDate.ShadowDecoration.Parent = this.checkOutDate;
            this.checkOutDate.Size = new System.Drawing.Size(200, 36);
            this.checkOutDate.TabIndex = 37;
            this.checkOutDate.Value = new System.DateTime(2021, 10, 18, 17, 14, 58, 622);
            // this.checkOutDate.ValueChanged += new System.EventHandler(this.checkOutDate_ValueChanged);
            this.checkOutDate.Leave += new System.EventHandler(this.checkOutDate_Leave);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(730, 414);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(83, 22);
            this.guna2HtmlLabel4.TabIndex = 38;
            this.guna2HtmlLabel4.Text = "Check Out";
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.Transparent;
            this.btnCheckOut.BorderRadius = 30;
            this.btnCheckOut.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btnCheckOut.BorderThickness = 1;
            this.btnCheckOut.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnCheckOut.CheckedState.Parent = this.btnCheckOut;
            this.btnCheckOut.CustomImages.Parent = this.btnCheckOut;
            this.btnCheckOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCheckOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCheckOut.DisabledState.Parent = this.btnCheckOut;
            this.btnCheckOut.FillColor = System.Drawing.Color.White;
            this.btnCheckOut.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCheckOut.ForeColor = System.Drawing.Color.Black;
            this.btnCheckOut.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btnCheckOut.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.HoverState.Parent = this.btnCheckOut;
            this.btnCheckOut.Location = new System.Drawing.Point(1009, 448);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.ShadowDecoration.Parent = this.btnCheckOut;
            this.btnCheckOut.Size = new System.Drawing.Size(180, 45);
            this.btnCheckOut.TabIndex = 39;
            this.btnCheckOut.Text = "Check Out ";
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // UC_CustomerCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.checkOutDate);
            this.Controls.Add(this.roomNo);
            this.Controls.Add(this.Cname);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.customerCheckoutBoard);
            this.Controls.Add(this.name);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel13);
            this.Name = "UC_CustomerCheckOut";
            this.Size = new System.Drawing.Size(1274, 549);
            this.Load += new System.EventHandler(this.UC_CustomerCheckOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerCheckoutBoard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2TextBox name;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel13;
        private Guna.UI2.WinForms.Guna2DataGridView customerCheckoutBoard;
        private Guna.UI2.WinForms.Guna2Button btnCheckOut;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2DateTimePicker checkOutDate;
        private Guna.UI2.WinForms.Guna2TextBox roomNo;
        private Guna.UI2.WinForms.Guna2TextBox Cname;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}
