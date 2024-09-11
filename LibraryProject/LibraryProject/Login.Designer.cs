namespace LibraryProject
{
    partial class Login
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Login_picBox = new ReaLTaiizor.Controls.HopePictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.hopePictureBox1 = new ReaLTaiizor.Controls.HopePictureBox();
            this.lb_Name = new ReaLTaiizor.Controls.DungeonLabel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.hopeTextBox1 = new ReaLTaiizor.Controls.HopeTextBox();
            this.hopeTextBox2 = new ReaLTaiizor.Controls.HopeTextBox();
            this.materialSwitch1 = new ReaLTaiizor.Controls.MaterialSwitch();
            this.lb_forgetID = new ReaLTaiizor.Controls.FoxLinkLabel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_AddMembers = new ReaLTaiizor.Controls.FoxButton();
            this.btn_Confirm = new ReaLTaiizor.Controls.FoxButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Login_picBox)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hopePictureBox1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Ivory;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.Login_picBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1300, 700);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Login_picBox
            // 
            this.Login_picBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.Login_picBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Login_picBox.Location = new System.Drawing.Point(390, 0);
            this.Login_picBox.Margin = new System.Windows.Forms.Padding(0);
            this.Login_picBox.Name = "Login_picBox";
            this.Login_picBox.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.tableLayoutPanel1.SetRowSpan(this.Login_picBox, 2);
            this.Login_picBox.Size = new System.Drawing.Size(910, 700);
            this.Login_picBox.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.Login_picBox.TabIndex = 0;
            this.Login_picBox.TabStop = false;
            this.Login_picBox.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.Controls.Add(this.hopePictureBox1, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lb_Name, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel1.SetRowSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.96272F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.51864F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.51863F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(388, 698);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // hopePictureBox1
            // 
            this.hopePictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.hopePictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.hopePictureBox1.Location = new System.Drawing.Point(135, 50);
            this.hopePictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.hopePictureBox1.Name = "hopePictureBox1";
            this.hopePictureBox1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.hopePictureBox1.Size = new System.Drawing.Size(194, 113);
            this.hopePictureBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.hopePictureBox1.TabIndex = 0;
            this.hopePictureBox1.TabStop = false;
            this.hopePictureBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.SetColumnSpan(this.lb_Name, 3);
            this.lb_Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Name.Font = new System.Drawing.Font("휴먼모음T", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.lb_Name.Location = new System.Drawing.Point(1, 164);
            this.lb_Name.Margin = new System.Windows.Forms.Padding(1);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lb_Name.Size = new System.Drawing.Size(386, 48);
            this.lb_Name.TabIndex = 1;
            this.lb_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel2.SetColumnSpan(this.tableLayoutPanel3, 3);
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.Controls.Add(this.hopeTextBox1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.hopeTextBox2, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.materialSwitch1, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.lb_forgetID, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 5);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 213);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 7;
            this.tableLayoutPanel2.SetRowSpan(this.tableLayoutPanel3, 2);
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(388, 485);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // hopeTextBox1
            // 
            this.hopeTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.hopeTextBox1.BackColor = System.Drawing.Color.White;
            this.hopeTextBox1.BaseColor = System.Drawing.Color.Olive;
            this.hopeTextBox1.BorderColorA = System.Drawing.Color.Olive;
            this.hopeTextBox1.BorderColorB = System.Drawing.Color.Olive;
            this.tableLayoutPanel3.SetColumnSpan(this.hopeTextBox1, 2);
            this.hopeTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeTextBox1.Hint = "";
            this.hopeTextBox1.Location = new System.Drawing.Point(30, 100);
            this.hopeTextBox1.Margin = new System.Windows.Forms.Padding(30, 20, 30, 3);
            this.hopeTextBox1.MaxLength = 32767;
            this.hopeTextBox1.Multiline = false;
            this.hopeTextBox1.Name = "hopeTextBox1";
            this.hopeTextBox1.PasswordChar = '\0';
            this.hopeTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.hopeTextBox1.SelectedText = "";
            this.hopeTextBox1.SelectionLength = 0;
            this.hopeTextBox1.SelectionStart = 0;
            this.hopeTextBox1.Size = new System.Drawing.Size(328, 38);
            this.hopeTextBox1.TabIndex = 0;
            this.hopeTextBox1.TabStop = false;
            this.hopeTextBox1.UseSystemPasswordChar = false;
            // 
            // hopeTextBox2
            // 
            this.hopeTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.hopeTextBox2.BackColor = System.Drawing.Color.White;
            this.hopeTextBox2.BaseColor = System.Drawing.Color.Olive;
            this.hopeTextBox2.BorderColorA = System.Drawing.Color.Olive;
            this.hopeTextBox2.BorderColorB = System.Drawing.Color.Olive;
            this.tableLayoutPanel3.SetColumnSpan(this.hopeTextBox2, 2);
            this.hopeTextBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeTextBox2.Hint = "";
            this.hopeTextBox2.Location = new System.Drawing.Point(30, 166);
            this.hopeTextBox2.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.hopeTextBox2.MaxLength = 32767;
            this.hopeTextBox2.Multiline = false;
            this.hopeTextBox2.Name = "hopeTextBox2";
            this.hopeTextBox2.PasswordChar = '\0';
            this.hopeTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.hopeTextBox2.SelectedText = "";
            this.hopeTextBox2.SelectionLength = 0;
            this.hopeTextBox2.SelectionStart = 0;
            this.hopeTextBox2.Size = new System.Drawing.Size(328, 38);
            this.hopeTextBox2.TabIndex = 1;
            this.hopeTextBox2.TabStop = false;
            this.hopeTextBox2.UseSystemPasswordChar = false;
            // 
            // materialSwitch1
            // 
            this.materialSwitch1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialSwitch1.AutoSize = true;
            this.materialSwitch1.Depth = 0;
            this.materialSwitch1.Location = new System.Drawing.Point(2, 224);
            this.materialSwitch1.Margin = new System.Windows.Forms.Padding(2);
            this.materialSwitch1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialSwitch1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialSwitch1.Name = "materialSwitch1";
            this.materialSwitch1.Ripple = true;
            this.materialSwitch1.Size = new System.Drawing.Size(151, 36);
            this.materialSwitch1.TabIndex = 4;
            this.materialSwitch1.Text = "아이디 기억하기";
            this.materialSwitch1.UseAccentColor = false;
            this.materialSwitch1.UseVisualStyleBackColor = true;
            // 
            // lb_forgetID
            // 
            this.lb_forgetID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_forgetID.BackColor = System.Drawing.Color.Transparent;
            this.lb_forgetID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_forgetID.DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.lb_forgetID.EnabledCalc = true;
            this.lb_forgetID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lb_forgetID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(221)))));
            this.lb_forgetID.Location = new System.Drawing.Point(157, 232);
            this.lb_forgetID.Margin = new System.Windows.Forms.Padding(2, 10, 2, 2);
            this.lb_forgetID.Name = "lb_forgetID";
            this.lb_forgetID.OverColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(140)))), ((int)(((byte)(229)))));
            this.lb_forgetID.Size = new System.Drawing.Size(229, 18);
            this.lb_forgetID.TabIndex = 5;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel3.SetColumnSpan(this.tableLayoutPanel4, 2);
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.btn_AddMembers, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_Confirm, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(1, 337);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(386, 72);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // btn_AddMembers
            // 
            this.btn_AddMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AddMembers.BackColor = System.Drawing.Color.Transparent;
            this.btn_AddMembers.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_AddMembers.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.btn_AddMembers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddMembers.DisabledBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_AddMembers.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.btn_AddMembers.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(178)))), ((int)(((byte)(190)))));
            this.btn_AddMembers.DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btn_AddMembers.EnabledCalc = true;
            this.btn_AddMembers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btn_AddMembers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(90)))));
            this.btn_AddMembers.Location = new System.Drawing.Point(53, 3);
            this.btn_AddMembers.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.btn_AddMembers.Name = "btn_AddMembers";
            this.btn_AddMembers.OverColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btn_AddMembers.Size = new System.Drawing.Size(120, 40);
            this.btn_AddMembers.TabIndex = 0;
            this.btn_AddMembers.Text = "회원가입";
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.BackColor = System.Drawing.Color.Transparent;
            this.btn_Confirm.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_Confirm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.btn_Confirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Confirm.DisabledBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_Confirm.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.btn_Confirm.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(178)))), ((int)(((byte)(190)))));
            this.btn_Confirm.DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btn_Confirm.EnabledCalc = true;
            this.btn_Confirm.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btn_Confirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(90)))));
            this.btn_Confirm.Location = new System.Drawing.Point(213, 3);
            this.btn_Confirm.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.OverColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btn_Confirm.Size = new System.Drawing.Size(120, 40);
            this.btn_Confirm.TabIndex = 1;
            this.btn_Confirm.Text = "로그인";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(261, 65);
            this.Name = "Login";
            this.Text = "로그인";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Login_picBox)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hopePictureBox1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ReaLTaiizor.Controls.HopePictureBox Login_picBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private ReaLTaiizor.Controls.HopePictureBox hopePictureBox1;
        private ReaLTaiizor.Controls.DungeonLabel lb_Name;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBox1;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBox2;
        private ReaLTaiizor.Controls.MaterialSwitch materialSwitch1;
        private ReaLTaiizor.Controls.FoxLinkLabel lb_forgetID;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private ReaLTaiizor.Controls.FoxButton btn_AddMembers;
        private ReaLTaiizor.Controls.FoxButton btn_Confirm;
    }
}

