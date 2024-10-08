using System;

class StudentAssessment
{
    private int[] ratings;

    public StudentAssessment()
    {
        ratings = new int[10];
        Random rand = new Random();
        for (int i = 0; i < ratings.Length; i++)
        {
            ratings[i] = rand.Next(56, 101); // випадкові числа від 56 до 100
        }
    }

    public double StRating()
    {
        double total = 0;
        foreach (int rating in ratings)
        {
            total += rating;
        }
        return total / ratings.Length;
    }
}

class Student
{
    public void MyRating()
    {
        StudentAssessment strating1 = new StudentAssessment();
        StudentAssessment strating2 = new StudentAssessment();

        double module1Rating = strating1.StRating();
        double module2Rating = strating2.StRating();
        double averageRating = (module1Rating + module2Rating) / 2;

        Console.WriteLine($"Рейтинг за перший модуль: {module1Rating}");
        Console.WriteLine($"Рейтинг за другий модуль: {module2Rating}");
        Console.WriteLine($"Середній рейтинг за семестр: {averageRating}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student();
        student.MyRating();
        Console.ReadKey();
    }
}

