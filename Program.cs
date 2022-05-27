Console.Title = "27/05/22";
Console.WriteLine("Codewars Questions");
Console.WriteLine("------------------");
NewLine();




//new line method
static void NewLine()
{
    Console.WriteLine("\n");
}

//1

//Complete the function so that it finds the average of the three scores 
//passed to it and returns the letter value associated with that grade.

//Numerical Score	Letter Grade
//90 <= score <= 100	'A'
//80 <= score < 90	'B'
//70 <= score < 80	'C'
//60 <= score < 70	'D'
//0 <= score < 60	'F'

//GetGrade(80, 80, 70);

//static char GetGrade(int s1, int s2, int s3)
//{
//    //Your code goes here...
//    int[] average = new int[] { s1, s2, s3 };
//    double score = average.Average();
//    char output;
//    if (score >= 90 || score <= 100)
//    {
//        Console.WriteLine("A");
//    }
//    else if (score >= 80 || score < 90)
//    {
//        Console.WriteLine("B");
//    }
//    else if (score >= 70 || score < 80)
//    {
//        Console.WriteLine("C");
//    }
//    else if (score >= 60 || score < 70)
//    {
//        Console.WriteLine("D");
//    }
//    else
//    {
//        Console.WriteLine("F");
//    }

//    return 'F';
//}


Console.WriteLine(GetGrade(90, 85, 85));

//this was one of the shorthands, I couldn't get it to work correctly
static char GetGrade(int s1, int s2, int s3)
{
    var s = (s1 + s2 + s3) / 3;
    if (s < 60) return 'F';
    if (s < 70) return 'D';
    if (s < 80) return 'C';
    if (s < 90) return 'B';
    return 'A';
}


//2
//Very simple, given an integer or a floating-point number, find its opposite.

static int Opposite(int num)
{
    return -num;
}


//3
//You are given the length and width of a 4-sided polygon. The polygon can either be a rectangle or a square.
//If it is a square, return its area. If it is a rectangle, return its perimeter.

//area_or_perimeter(6, 10) --> 32
//area_or_perimeter(3, 3)-- > 9

//Note: for the purposes of this kata you will assume that it is a square 
//if its length and width are equal, otherwise it is a rectangle.

Console.WriteLine(MathCheck.AreaOrPerimeter(5, 5));

public class MathCheck
{
    public static int AreaOrPerimeter(int l, int w)
    {
        // code goes here
        if (l == w) return l * w;
        else return (l + w) * 2;
    }
}