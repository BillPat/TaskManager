namespace TaskManagerApplication
{
    public partial class MainForm : Form
    {
        private TaskManager taskManager = new TaskManager();

        public MainForm()
        {
            InitializeComponent();

            this.MinimumSize = new Size(800, 480);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            taskManager.LoadTasksFromFile();
            LoadTasksToDataGridView(taskManager.GetTasks());
        }

        private void LoadTasksToDataGridView(List<Task> tasks)
        {
            taskGridView.Rows.Clear();

            foreach (var task in tasks)
            {
                taskGridView.Rows.Add(task.Title, task.Description, task.Priority.ToString(), task.DueDate.ToShortDateString());
            }
        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            string title = titleTextBox.Text;
            string description = descriptionTextBox.Text;
            int priority = (int)priorityNumericUpDown.Value;
            DateTime dueDate = dueDatePicker.Value;

            if (string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("Task title cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Task newTask = new Task(title, description, priority, dueDate);
            taskManager.AddTask(newTask);

            LoadTasksToDataGridView(taskManager.GetTasks());

            titleTextBox.Clear();
            descriptionTextBox.Clear();
            priorityNumericUpDown.Value = 1;
            dueDatePicker.Value = DateTime.Now.AddDays(1);
        }

        private void deleteTaskButton_Click(object sender, EventArgs e)
        {
            if (taskGridView.SelectedRows.Count > 0)
            {
                // Παίρνουμε τον τίτλο του επιλεγμένου task
                string taskTitle = taskGridView.SelectedRows[0].Cells[0].Value.ToString();

                // Διαγραφή του task από το TaskManager
                taskManager.DeleteTask(taskTitle);

                // Ενημέρωση του DataGridView
                LoadTasksToDataGridView(taskManager.GetTasks());
            }
            else
            {
                MessageBox.Show("Please select a task to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void priorityNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void taskGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dueDatePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
