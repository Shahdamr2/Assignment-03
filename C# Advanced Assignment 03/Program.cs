namespace C__Advanced_Assignment_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1 - Student Grade Manager
            #region Q1
                List<int> grades = new List<int> { 85, 92, 78, 95, 88, 70, 100, 65 };
            #endregion
            #region Q2
            //Console.WriteLine("Student Grades:");
            //Console.WriteLine(string.Join(",", grades));
            //Console.WriteLine($"Count :{grades.Count}");
            //Console.WriteLine($"First Grade : {grades[0]}");
            //Console.WriteLine($"Last Grade : {grades[grades.Count - 1]}");

            #endregion
            #region Q3
            //grades.Sort();
            //Console.WriteLine("Sorted Grades:");
            //Console.WriteLine(string.Join(",", grades));
            #endregion
            #region Q4
            //int firstAbove90= grades.First(x => x>90);
            //Console.WriteLine($"First grade above 90: {firstAbove90}");
            #endregion
            #region Q5
            List<int> GradesBelow75 = grades.Where(x => x < 75).ToList();
            Console.WriteLine("Failing Grades:");
            Console.WriteLine(string.Join(", ", GradesBelow75));
            #endregion
            #region Q6
            grades.RemoveAll(x => x < 75);
            Console.WriteLine("Grades after removing failing grades:");
            Console.WriteLine(string.Join(", ", grades));
            #endregion

            #endregion
        }
    }
}
