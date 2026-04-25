namespace prac4oop_examp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            Person new_person;
            if (NameBox.Text == "") {
                MessageBox.Show("Please enter a name.");
            }
            if (AgeBox.Text != "")
            {
                if (ProfessionBox.Text != "")
                {
                    new_person = new Person(NameBox.Text, Convert .ToInt32(AgeBox.Text), ProfessionBox.Text);
                }
                else
                {
                    new_person = new Person(NameBox.Text, Convert.ToInt32(AgeBox.Text));
                }
            }
            else if(ProfessionBox.Text != "")
            {
                new_person = new Person(NameBox.Text, ProfessionBox.Text);
            }
            else
            {
                new_person = new Person(NameBox.Text);
            }
            
            TextBox.Text += new_person.GetInfo();
        }
    }
}
