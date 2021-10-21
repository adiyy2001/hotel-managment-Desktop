
namespace Hotel_managment.all_user_control
{
    partial class UC_AddRoom
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
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.rooms = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtRoomNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBed = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnAddRoom = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.rooms)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(160, 36);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(214, 35);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Add New Room";
            // 
            // rooms
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.rooms.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.rooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.rooms.BackgroundColor = System.Drawing.Color.White;
            this.rooms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rooms.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.rooms.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.rooms.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.rooms.DefaultCellStyle = dataGridViewCellStyle3;
            this.rooms.EnableHeadersVisualStyles = false;
            this.rooms.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.rooms.Location = new System.Drawing.Point(160, 89);
            this.rooms.Name = "rooms";
            this.rooms.RowHeadersVisible = false;
            this.rooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rooms.Size = new System.Drawing.Size(545, 367);
            this.rooms.TabIndex = 1;
            this.rooms.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.rooms.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.rooms.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.rooms.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.rooms.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.rooms.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.rooms.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.rooms.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rooms.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.rooms.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.rooms.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.rooms.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.rooms.ThemeStyle.HeaderStyle.Height = 4;
            this.rooms.ThemeStyle.ReadOnly = false;
            this.rooms.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.rooms.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.rooms.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.rooms.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.rooms.ThemeStyle.RowsStyle.Height = 22;
            this.rooms.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.rooms.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(834, 380);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(40, 22);
            this.guna2HtmlLabel3.TabIndex = 3;
            this.guna2HtmlLabel3.Text = "Price";
            // 
            // txtRoomNo
            // 
            this.txtRoomNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoomNo.CustomizableEdges.BottomRight = false;
            this.txtRoomNo.CustomizableEdges.TopLeft = false;
            this.txtRoomNo.CustomizableEdges.TopRight = false;
            this.txtRoomNo.DefaultText = "";
            this.txtRoomNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRoomNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRoomNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoomNo.DisabledState.Parent = this.txtRoomNo;
            this.txtRoomNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoomNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoomNo.FocusedState.Parent = this.txtRoomNo;
            this.txtRoomNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRoomNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoomNo.HoverState.Parent = this.txtRoomNo;
            this.txtRoomNo.Location = new System.Drawing.Point(834, 180);
            this.txtRoomNo.Name = "txtRoomNo";
            this.txtRoomNo.PasswordChar = '\0';
            this.txtRoomNo.PlaceholderText = "Enter room no";
            this.txtRoomNo.SelectedText = "";
            this.txtRoomNo.ShadowDecoration.Parent = this.txtRoomNo;
            this.txtRoomNo.Size = new System.Drawing.Size(341, 36);
            this.txtRoomNo.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtRoomNo.TabIndex = 6;
            // 
            // txtPrice
            // 
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.DefaultText = "";
            this.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.DisabledState.Parent = this.txtPrice;
            this.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.FocusedState.Parent = this.txtPrice;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.HoverState.Parent = this.txtPrice;
            this.txtPrice.Location = new System.Drawing.Point(834, 420);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.PlaceholderText = "Enter room price";
            this.txtPrice.SelectedText = "";
            this.txtPrice.ShadowDecoration.Parent = this.txtPrice;
            this.txtPrice.Size = new System.Drawing.Size(341, 36);
            this.txtPrice.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtPrice.TabIndex = 8;
            // 
            // txtBed
            // 
            this.txtBed.BackColor = System.Drawing.Color.Transparent;
            this.txtBed.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtBed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtBed.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBed.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBed.FocusedState.Parent = this.txtBed;
            this.txtBed.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtBed.HoverState.Parent = this.txtBed;
            this.txtBed.ItemHeight = 30;
            this.txtBed.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Triple"});
            this.txtBed.ItemsAppearance.Parent = this.txtBed;
            this.txtBed.Location = new System.Drawing.Point(834, 331);
            this.txtBed.Name = "txtBed";
            this.txtBed.ShadowDecoration.Parent = this.txtBed;
            this.txtBed.Size = new System.Drawing.Size(341, 36);
            this.txtBed.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtBed.TabIndex = 10;
            // 
            // txtType
            // 
            this.txtType.BackColor = System.Drawing.Color.Transparent;
            this.txtType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtType.FocusedState.Parent = this.txtType;
            this.txtType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtType.HoverState.Parent = this.txtType;
            this.txtType.ItemHeight = 30;
            this.txtType.Items.AddRange(new object[] {
            "Ac",
            "Non-Ac"});
            this.txtType.ItemsAppearance.Parent = this.txtType;
            this.txtType.Location = new System.Drawing.Point(834, 258);
            this.txtType.Name = "txtType";
            this.txtType.ShadowDecoration.Parent = this.txtType;
            this.txtType.Size = new System.Drawing.Size(341, 36);
            this.txtType.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtType.TabIndex = 11;
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.BorderRadius = 23;
            this.btnAddRoom.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnAddRoom.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btnAddRoom.CheckedState.Parent = this.btnAddRoom;
            this.btnAddRoom.CustomImages.Parent = this.btnAddRoom;
            this.btnAddRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddRoom.DisabledState.Parent = this.btnAddRoom;
            this.btnAddRoom.FillColor = System.Drawing.Color.White;
            this.btnAddRoom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddRoom.ForeColor = System.Drawing.Color.Black;
            this.btnAddRoom.HoverState.Parent = this.btnAddRoom;
            this.btnAddRoom.Location = new System.Drawing.Point(1020, 489);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.ShadowDecoration.Parent = this.btnAddRoom;
            this.btnAddRoom.Size = new System.Drawing.Size(155, 45);
            this.btnAddRoom.TabIndex = 12;
            this.btnAddRoom.Text = "Add room";
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(834, 152);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(105, 22);
            this.guna2HtmlLabel6.TabIndex = 2;
            this.guna2HtmlLabel6.Text = "Room number";
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(834, 303);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(32, 22);
            this.guna2HtmlLabel7.TabIndex = 4;
            this.guna2HtmlLabel7.Text = "Bed";
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(834, 220);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(82, 22);
            this.guna2HtmlLabel8.TabIndex = 5;
            this.guna2HtmlLabel8.Text = "Room Type";
            // 
            // UC_AddRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.btnAddRoom);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtBed);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtRoomNo);
            this.Controls.Add(this.guna2HtmlLabel8);
            this.Controls.Add(this.guna2HtmlLabel7);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.rooms);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Name = "UC_AddRoom";
            this.Size = new System.Drawing.Size(1274, 583);
            this.Load += new System.EventHandler(this.UC_AddRoom_Load);
            this.Enter += new System.EventHandler(this.UC_AddRoom_Enter);
            this.Leave += new System.EventHandler(this.UC_AddRoom_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.rooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2DataGridView rooms;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox txtRoomNo;
        private Guna.UI2.WinForms.Guna2TextBox txtPrice;
        private Guna.UI2.WinForms.Guna2ComboBox txtBed;
        private Guna.UI2.WinForms.Guna2ComboBox txtType;
        private Guna.UI2.WinForms.Guna2Button btnAddRoom;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
    }
}
