namespace gradebook;

  public  class Book
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

        public Statistics  GetStatistics(){
             var highest_grade = double.MinValue;
            var lowest_grade =double.MaxValue;

            foreach(double grade in grades){
                highest_grade = Math.Max(grade, highest_grade);
                lowest_grade = Math.Min(grade, highest_grade);
            }

            var stat = new Statistics();
            stat.Highest = highest_grade;
            stat.Lowest = lowest_grade;

            return stat;

        }

        
    }
