namespace TaskManagerApplication
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            addTaskButton = new Guna.UI2.WinForms.Guna2Button();
            dueDatePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            priorityNumericUpDown = new Guna.UI2.WinForms.Guna2NumericUpDown();
            descriptionTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            titleTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            taskGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            TitleColumn = new DataGridViewTextBoxColumn();
            DescriptionColumn = new DataGridViewTextBoxColumn();
            PriorityColumn = new DataGridViewTextBoxColumn();
            DueDateColumn = new DataGridViewTextBoxColumn();
            deleteTaskButton = new Guna.UI2.WinForms.Guna2Button();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)priorityNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)taskGridView).BeginInit();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            guna2Panel1.Controls.Add(addTaskButton);
            guna2Panel1.Controls.Add(dueDatePicker);
            guna2Panel1.Controls.Add(priorityNumericUpDown);
            guna2Panel1.Controls.Add(descriptionTextBox);
            guna2Panel1.Controls.Add(titleTextBox);
            guna2Panel1.Controls.Add(taskGridView);
            guna2Panel1.Controls.Add(deleteTaskButton);
            guna2Panel1.CustomizableEdges = customizableEdges13;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges14;
            guna2Panel1.Size = new Size(800, 450);
            guna2Panel1.TabIndex = 0;
            // 
            // addTaskButton
            // 
            addTaskButton.CustomizableEdges = customizableEdges1;
            addTaskButton.DefaultAutoSize = true;
            addTaskButton.Font = new Font("Segoe UI", 9F);
            addTaskButton.ForeColor = Color.White;
            addTaskButton.Location = new Point(690, 400);
            addTaskButton.Name = "addTaskButton";
            addTaskButton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            addTaskButton.Size = new Size(80, 27);
            addTaskButton.TabIndex = 5;
            addTaskButton.Text = "Add Task";
            addTaskButton.Click += addTaskButton_Click;
            // 
            // dueDatePicker
            // 
            dueDatePicker.Checked = true;
            dueDatePicker.CustomizableEdges = customizableEdges3;
            dueDatePicker.FillColor = Color.FromArgb(192, 192, 255);
            dueDatePicker.Font = new Font("Segoe UI", 9F);
            dueDatePicker.Format = DateTimePickerFormat.Long;
            dueDatePicker.Location = new Point(469, 400);
            dueDatePicker.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dueDatePicker.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dueDatePicker.Name = "dueDatePicker";
            dueDatePicker.ShadowDecoration.CustomizableEdges = customizableEdges4;
            dueDatePicker.Size = new Size(215, 27);
            dueDatePicker.TabIndex = 4;
            dueDatePicker.Value = new DateTime(2024, 11, 16, 16, 40, 55, 812);
            dueDatePicker.ValueChanged += dueDatePicker_ValueChanged;
            // 
            // priorityNumericUpDown
            // 
            priorityNumericUpDown.BackColor = Color.Transparent;
            priorityNumericUpDown.CustomizableEdges = customizableEdges5;
            priorityNumericUpDown.Font = new Font("Segoe UI", 9F);
            priorityNumericUpDown.Location = new Point(404, 400);
            priorityNumericUpDown.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            priorityNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            priorityNumericUpDown.Name = "priorityNumericUpDown";
            priorityNumericUpDown.ShadowDecoration.CustomizableEdges = customizableEdges6;
            priorityNumericUpDown.Size = new Size(59, 30);
            priorityNumericUpDown.TabIndex = 3;
            priorityNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            priorityNumericUpDown.ValueChanged += priorityNumericUpDown_ValueChanged;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.CustomizableEdges = customizableEdges7;
            descriptionTextBox.DefaultText = "";
            descriptionTextBox.Font = new Font("Segoe UI", 9F);
            descriptionTextBox.Location = new Point(148, 400);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.PasswordChar = '\0';
            descriptionTextBox.PlaceholderText = "Enter Task Description";
            descriptionTextBox.SelectedText = "";
            descriptionTextBox.ShadowDecoration.CustomizableEdges = customizableEdges8;
            descriptionTextBox.Size = new Size(250, 30);
            descriptionTextBox.TabIndex = 2;
            // 
            // titleTextBox
            // 
            titleTextBox.CustomizableEdges = customizableEdges9;
            titleTextBox.DefaultText = "";
            titleTextBox.Font = new Font("Segoe UI", 9F);
            titleTextBox.Location = new Point(20, 400);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.PasswordChar = '\0';
            titleTextBox.PlaceholderText = "Enter Task Title";
            titleTextBox.SelectedText = "";
            titleTextBox.ShadowDecoration.CustomizableEdges = customizableEdges10;
            titleTextBox.Size = new Size(122, 30);
            titleTextBox.TabIndex = 1;
            // 
            // taskGridView
            // 
            taskGridView.AllowUserToAddRows = false;
            taskGridView.AllowUserToDeleteRows = false;
            taskGridView.AllowUserToResizeColumns = false;
            taskGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            taskGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            taskGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            taskGridView.ColumnHeadersHeight = 17;
            taskGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            taskGridView.Columns.AddRange(new DataGridViewColumn[] { TitleColumn, DescriptionColumn, PriorityColumn, DueDateColumn });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            taskGridView.DefaultCellStyle = dataGridViewCellStyle3;
            taskGridView.GridColor = Color.FromArgb(231, 229, 255);
            taskGridView.Location = new Point(20, 12);
            taskGridView.Name = "taskGridView";
            taskGridView.ReadOnly = true;
            taskGridView.RowHeadersVisible = false;
            taskGridView.Size = new Size(750, 322);
            taskGridView.TabIndex = 0;
            taskGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            taskGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            taskGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            taskGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            taskGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            taskGridView.ThemeStyle.BackColor = Color.White;
            taskGridView.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            taskGridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            taskGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            taskGridView.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            taskGridView.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            taskGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            taskGridView.ThemeStyle.HeaderStyle.Height = 17;
            taskGridView.ThemeStyle.ReadOnly = true;
            taskGridView.ThemeStyle.RowsStyle.BackColor = Color.White;
            taskGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            taskGridView.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            taskGridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            taskGridView.ThemeStyle.RowsStyle.Height = 25;
            taskGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            taskGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            taskGridView.CellContentClick += taskGridView_CellContentClick;
            // 
            // TitleColumn
            // 
            TitleColumn.HeaderText = "Title";
            TitleColumn.Name = "TitleColumn";
            TitleColumn.ReadOnly = true;
            // 
            // DescriptionColumn
            // 
            DescriptionColumn.HeaderText = "Description";
            DescriptionColumn.Name = "DescriptionColumn";
            DescriptionColumn.ReadOnly = true;
            // 
            // PriorityColumn
            // 
            PriorityColumn.HeaderText = "Priority";
            PriorityColumn.Name = "PriorityColumn";
            PriorityColumn.ReadOnly = true;
            // 
            // DueDateColumn
            // 
            DueDateColumn.HeaderText = "Due Date";
            DueDateColumn.Name = "DueDateColumn";
            DueDateColumn.ReadOnly = true;
            // 
            // deleteTaskButton
            // 
            deleteTaskButton.CustomizableEdges = customizableEdges11;
            deleteTaskButton.Font = new Font("Segoe UI", 9F);
            deleteTaskButton.ForeColor = Color.White;
            deleteTaskButton.Location = new Point(683, 340);
            deleteTaskButton.Name = "deleteTaskButton";
            deleteTaskButton.ShadowDecoration.CustomizableEdges = customizableEdges12;
            deleteTaskButton.Size = new Size(87, 27);
            deleteTaskButton.TabIndex = 6;
            deleteTaskButton.Text = "Delete Task";
            deleteTaskButton.Click += deleteTaskButton_Click;
            // 
            // MainForm
            // 
            ClientSize = new Size(800, 450);
            Controls.Add(guna2Panel1);
            Name = "MainForm";
            Text = "Task Manager";
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)priorityNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)taskGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button deleteTaskButton;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DataGridView taskGridView;
        private Guna.UI2.WinForms.Guna2Button addTaskButton;
        private Guna.UI2.WinForms.Guna2DateTimePicker dueDatePicker;
        private Guna.UI2.WinForms.Guna2NumericUpDown priorityNumericUpDown;
        private Guna.UI2.WinForms.Guna2TextBox descriptionTextBox;
        private Guna.UI2.WinForms.Guna2TextBox titleTextBox;
        private DataGridViewTextBoxColumn TitleColumn;
        private DataGridViewTextBoxColumn DescriptionColumn;
        private DataGridViewTextBoxColumn PriorityColumn;
        private DataGridViewTextBoxColumn DueDateColumn;
    }
}
