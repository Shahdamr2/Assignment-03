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
            //List<int> GradesBelow75 = grades.Where(x => x < 75).ToList();
            //Console.WriteLine("Failing Grades:");
            //Console.WriteLine(string.Join(", ", GradesBelow75));
            #endregion
            #region Q6
            //grades.RemoveAll(x => x < 75);
            //Console.WriteLine("Grades after removing failing grades:");
            //Console.WriteLine(string.Join(", ", grades));
            #endregion
            #region Q7
            //bool has100= grades.Any(x => x == 100);
            //Console.WriteLine(has100);
            #endregion
            #region Q8
            //List<string> gradeMessages = grades.Select(x => $"grade : {x}").ToList();
            //foreach(string message in gradeMessages)
            //{
            //    Console.WriteLine(message);
            //}
            #endregion

            #endregion
            #region Exercise 2 - Leaderboard
            #region Q1
            SortedDictionary<int, string> leaderboard = new SortedDictionary<int, string>();
            leaderboard.Add(500, "Shahd");
            leaderboard.Add(200, "Amr");
            leaderboard.Add(800, "Ali");
            leaderboard.Add(350, "Mona");
            #endregion
            #region Q2
            //foreach (var entry in leaderboard)
            //{
            //    Console.WriteLine($"{entry.Key} = {entry.Value}");
            //}
            #endregion
            #region Q3
            //int firstKey = leaderboard.First().Key;
            //string firstValue = leaderboard.First().Value;

            //Console.WriteLine($"First Key: {firstKey}");
            //Console.WriteLine($"First Value: {firstValue}");
            #endregion
            #region Q4
            //leaderboard.ContainsKey(500);
            //Console.WriteLine($"Score 500 exists: {leaderboard.ContainsKey(500)}");
            #endregion
            #region Q5
            //leaderboard[999] => هيحصل Exception 
            //if (leaderboard.TryGetValue(999, out string player))
            //{
            //    Console.WriteLine(player);
            //}
            //else
            //{
            //    Console.WriteLine("Player not found");
            //}
            #endregion
            #region Q6
            //leaderboard.Remove(200);
            //foreach (var entry in leaderboard)
            //{
            //    Console.WriteLine($"{entry.Key} = {entry.Value}");
            //}
            #endregion
            #endregion
            #region Exercise 3 - Phone Book
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            phoneBook.Add("Shahd", "01157220098");
            phoneBook.Add("Sara", "01123456789");
            phoneBook.Add("Mona", "01234567890");
            phoneBook.Add("Omar", "01555555555");
            #endregion


        }
    }
}
