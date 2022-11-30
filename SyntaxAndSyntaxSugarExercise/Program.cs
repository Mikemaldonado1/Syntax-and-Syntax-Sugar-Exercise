namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            /*          

                       inferred typing
                       string interpolation
                       and the ternary operator


                       int answer = 4;
                       string response;

                       if (answer < 9) 
                       {
                           response = answer + " is less than nine";
                       }

                       else
                       {
                           response = answer + " is greater than or equal to nine";
                       }


           */

            int answer = 4;


            //Inferred Typing


            var response = "";
            Console.WriteLine(response);

            //String Interpolation

            int answer2 = 4;

            var response2 = (answer2 < 9)? $"{answer2} is less than nine" : $"{answer2} is greater than or equal to nine";  
            Console.WriteLine(response2);



            //Tertiary Operator

            int answer3 = 4;

            var response3 = (answer3< 9) ? "Your answer is less than nine" : "Your answer is greater than or equal to nine";  
            Console.WriteLine(response3);
                




        }
    }
}
