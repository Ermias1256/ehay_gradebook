namespace gradebook{

    class Book
    {
        List<double> grades;
        string name;

        public Book(string name){
          grades = new List<double>();
          this.name = name;
        }

        public void AddGrade(double grade){
            grades.Add(grade);
        }

    }
}