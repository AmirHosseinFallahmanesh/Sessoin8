namespace Demo
{
    public class Student
    {
        private string name;
        private string surname;
        private int age;
        private bool isAlive;

        public Student(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.isAlive = true;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public int  Age
        {
            get { return age; }
            set { age = value; }
        }

        public void Deactive()
        {
            this.isAlive = false;
        }
        public bool Exist { get => isAlive; }
    }
}
