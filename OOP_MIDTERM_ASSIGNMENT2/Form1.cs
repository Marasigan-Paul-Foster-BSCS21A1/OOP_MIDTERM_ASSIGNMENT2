namespace TODOlistapplication
{
    public partial class Form1 : Form
    {
        public static int i;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setheader();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddForm addform = new AddForm();
            addform.ShowDialog();
            dataGridView1.DataSource = null;
            setheader();
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Refresh();
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string presstask = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                i = Class1.Gettask().FindIndex(t => t.task == presstask);
                ConfirmAdd confirmadd = new ConfirmAdd();
                confirmadd.ShowDialog();
            }
            dataGridView1.DataSource = null;
            setheader();
            dataGridView1.Refresh();
        }

        void setheader()
        {
            var activeTasks = Class1.Gettask().Where(task => task.status.ToLower() != "done").ToList();
            dataGridView1.DataSource = activeTasks;
            dataGridView1.Columns[0].HeaderText = "Task";
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;

            var doneTask = Class1.Gettask().Where(task => task.status.ToLower() == "done").ToList();
            dataGridView2.DataSource = doneTask;
            dataGridView2.Columns[2].Visible = false;
            dataGridView2.Columns[0].HeaderText = "Task";
            dataGridView2.Columns[1].HeaderText = "Date Accomplised";
        }
    }

    public class UserTask
    {
        public string task { get; set; }
        public DateTime dateDone { get; set; }

        public string status { get; set; }

        public UserTask(string task, DateTime dateDone, string status)
        {
            this.task = task;
            this.dateDone = dateDone;
            this.status = status;
        }
    }
}
