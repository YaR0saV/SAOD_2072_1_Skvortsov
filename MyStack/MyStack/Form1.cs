namespace MyStack
{
    public partial class Form1 : Form
    {
        MyStack<int> myStack;
        public Form1()
        {
            InitializeComponent();
        }

        private void createStackButton_Click(object sender, EventArgs e)
        {
            try
            {
                myStack = new MyStack<int>(Convert.ToInt32(sizeTextBox.Text));
                showStack();
            }
            catch
            {
                MessageBox.Show("�������� ������ ������� �������.");
            }
        }

        private void pushItemButton_Click(object sender, EventArgs e)
        {
            try
            {
                myStack.Push(Convert.ToInt32(itemTextBox.Text));
                showStack();
            }
            catch
            {
                MessageBox.Show("������� ��������� ���������.");
            }
        }

        private void popItemButton_Click(object sender, EventArgs e)
        {
            try
            {
                popTextBox.Text = Convert.ToString(myStack.Pop());
                showStack();
            }
            catch
            {
                MessageBox.Show("������� �����.");
            }
        }

        private void peekItemButton_Click(object sender, EventArgs e)
        {
            try
            {
                peekTextBox.Text = Convert.ToString(myStack.Peek());
                showStack();
            }
            catch
            {
                MessageBox.Show("������� �����.");
            }
        }
        private void showStack()
        {
            stackListBox.Items.Clear();
            List<string> value = new();
            for (int i = 0; i < myStack.Top; i++)
            {
                value.Add(Convert.ToString(myStack.Values()[i]));
            }
            foreach (var item in value)
            {
                stackListBox.Items.Add(item);
            }

        }
    }
}