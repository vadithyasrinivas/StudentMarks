namespace StudentMarks
{
    public class Program
    {
        static void Main(string[] args)
        {
           Student student=new Student();
            student.Name = "Srinivas";
            student.Mark1 = 12;
            student.Mark2 = 13;
            student.Mark3 = 14;
            int total=student.GetTotal();
            //Console.WriteLine(total);
            double avarege = student.GetAvarege();
            //Console.WriteLine(avarege);
        }
    }
}
