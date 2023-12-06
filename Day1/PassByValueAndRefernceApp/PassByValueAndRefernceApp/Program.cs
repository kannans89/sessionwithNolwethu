namespace PassByValueAndRefernceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int score = 100;
            UpdateToZero(score);//passing by value
            Console.WriteLine($"score after update is {score}");

            int[] manyScores = { 100, 120, 150, 170 };
            Console.WriteLine(manyScores.GetHashCode());

            UpdateManyScoresToZero(manyScores);//passing reference
            foreach (int item in manyScores)
            {
                Console.WriteLine(item);
            }

           
        }

        static void UpdateManyScoresToZero(int[] myScores)
        {
            Console.WriteLine(myScores.GetHashCode());

            for (int index = 0; index < myScores.Length; index++)
            {
                myScores[index] = 0;
            }

            
        }

        static void UpdateToZero(int myscore)
        {
            myscore = 0;
        }
    }
}