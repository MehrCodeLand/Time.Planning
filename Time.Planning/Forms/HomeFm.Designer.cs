namespace Time.Planning.Forms
{
    partial class HomeFm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ExitBtn = new Button();
            StsrtBtn = new Button();
            TaskNameBox = new TextBox();
            label1 = new Label();
            EndTaskBtn = new Button();
            ScoreBoard = new TextBox();
            ChicksDataGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)ChicksDataGrid).BeginInit();
            SuspendLayout();
            // 
            // ExitBtn
            // 
            ExitBtn.BackColor = Color.Gainsboro;
            ExitBtn.FlatStyle = FlatStyle.Popup;
            ExitBtn.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ExitBtn.Location = new Point(322, 347);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(106, 35);
            ExitBtn.TabIndex = 0;
            ExitBtn.Text = "EXIT";
            ExitBtn.UseVisualStyleBackColor = false;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // StsrtBtn
            // 
            StsrtBtn.BackColor = Color.Gainsboro;
            StsrtBtn.FlatStyle = FlatStyle.Popup;
            StsrtBtn.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            StsrtBtn.Location = new Point(206, 264);
            StsrtBtn.Name = "StsrtBtn";
            StsrtBtn.Size = new Size(167, 35);
            StsrtBtn.TabIndex = 1;
            StsrtBtn.Text = "Start Task";
            StsrtBtn.UseVisualStyleBackColor = false;
            StsrtBtn.Click += StsrtBtn_Click;
            // 
            // TaskNameBox
            // 
            TaskNameBox.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            TaskNameBox.Location = new Point(261, 231);
            TaskNameBox.Name = "TaskNameBox";
            TaskNameBox.Size = new Size(288, 27);
            TaskNameBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(206, 234);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 3;
            label1.Text = "Title : ";
            // 
            // EndTaskBtn
            // 
            EndTaskBtn.BackColor = Color.Gainsboro;
            EndTaskBtn.FlatStyle = FlatStyle.Popup;
            EndTaskBtn.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EndTaskBtn.Location = new Point(379, 264);
            EndTaskBtn.Name = "EndTaskBtn";
            EndTaskBtn.Size = new Size(170, 35);
            EndTaskBtn.TabIndex = 4;
            EndTaskBtn.Text = "End Task";
            EndTaskBtn.UseVisualStyleBackColor = false;
            EndTaskBtn.Click += EndTaskBtn_Click;
            // 
            // ScoreBoard
            // 
            ScoreBoard.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ScoreBoard.Location = new Point(206, 305);
            ScoreBoard.Name = "ScoreBoard";
            ScoreBoard.Size = new Size(343, 27);
            ScoreBoard.TabIndex = 5;
            // 
            // ChicksDataGrid
            // 
            ChicksDataGrid.BackgroundColor = SystemColors.ActiveBorder;
            ChicksDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ChicksDataGrid.GridColor = Color.Silver;
            ChicksDataGrid.Location = new Point(23, 12);
            ChicksDataGrid.Name = "ChicksDataGrid";
            ChicksDataGrid.RowTemplate.Height = 25;
            ChicksDataGrid.Size = new Size(692, 213);
            ChicksDataGrid.TabIndex = 7;
            // 
            // HomeFm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = Properties.Resources.x_1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(727, 411);
            Controls.Add(ChicksDataGrid);
            Controls.Add(ScoreBoard);
            Controls.Add(EndTaskBtn);
            Controls.Add(label1);
            Controls.Add(TaskNameBox);
            Controls.Add(StsrtBtn);
            Controls.Add(ExitBtn);
            Font = new Font("Segoe UI Emoji", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "HomeFm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            ((System.ComponentModel.ISupportInitialize)ChicksDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ExitBtn;
        private Button StsrtBtn;
        private TextBox TaskNameBox;
        private Label label1;
        private Button EndTaskBtn;
        private TextBox ScoreBoard;
        private DataGridView ChicksDataGrid;
    }
}