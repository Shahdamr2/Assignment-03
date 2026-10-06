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
                grades.Sort();
                Console.WriteLine("Sorted Grades:");
                Console.WriteLine(string.Join(",", grades));
                #endregion

            #endregion
        }
    }
}
