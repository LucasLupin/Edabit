using System;

namespace EdabitVeryEasy
{
    internal class Program
    {
        // Declare an instance of:
        private static NextNumber? next;
        private static PowerCalculator? power;
        private static AgeToDays? Age;
        private static AreaOfTriangle? Area;
        private static Remainder? remainder;
        private static ZeroTrue? Zero;
        private static Lessthen100? Less;
        private static Something? Something;
        private static FlipBoolean? Flip;
        private static HoursToSeconds? Hours;
        private static SumOfPolygon? SumOfPolygon;
        private static AreTheNumberEqual? AreTheNumberEqual;
        private static BasicVariableASsignment? Basic;
        private static Using__? Using;
        private static BasketBall Bask;
        private static Rectangle? Rectangle;
        static void Main(string[] args)
        {
            // Initialize the instance of / Only if they are not static:
            next = new NextNumber();
            power = new PowerCalculator();
            Age = new AgeToDays();
            remainder = new Remainder();
            Zero = new ZeroTrue();
            Less = new Lessthen100();
            Something = new Something();
            Flip = new FlipBoolean();
            Hours = new HoursToSeconds();
            SumOfPolygon = new SumOfPolygon();
            AreTheNumberEqual = new AreTheNumberEqual();
            Basic = new BasicVariableASsignment();
            Using = new Using__();
            Bask = new BasketBall();
            Rectangle = new Rectangle();

            //########### Min To Sec ##############
            int result = EdabitVeryEasy.MinToSec(5);
            Console.WriteLine(result + " Seconds");
            //#####################################

            //########### Next Number #############
            int result2 = next.Nextnumber(6);
            Console.WriteLine(result2 + " NextNumber");
            //#####################################

            //######## Power Calculator ###########
            int result3 = power.PowerCalculation(4, 100);
            Console.WriteLine(result3 + " Power");
            //#####################################

            //######## Age To Day #################
            int result4 = Age.AgeToDay(10);
            Console.WriteLine(result4 + " Age In days");
            //#####################################

            //######## Area Of Triangle ###########
            int result5 = AreaOfTriangle.CalcTriangle(4, 199);
            Console.WriteLine(result5 + ": Area");
            //#####################################

            //######## Remainder ##################
            int result6 = remainder.CalcRemainder(2, 3);
            Console.WriteLine(result6 + " Remainder");
            //####################################

            //####### Zero or Less ###############
            bool result7 = Zero.ZeroLessTrue(6);
            Console.WriteLine(result7 + " Is it lower then 0 or 0");
            //####################################

            //####### Less then 100 ##############
            bool result8 = Less.Less100(45, 52);
            Console.WriteLine("Is it less then 100 " + result8);
            //####################################

            //########## Equal ###################
            bool result9 = Equal.Equals(22, 22);
            Console.WriteLine("Is it Equal: " + result9);
            //####################################

            //############ Something #############
            string result10 = Something.Somethingtext("is better than nothing");
            Console.WriteLine(result10);
             //####################################

            //############## Flip #################
            bool result11 = Flip.FlipBool(true);
            Console.WriteLine(result11 + " Is Not the same");
            //#####################################

            //########### Hour to Second ##########
            int result12 = Hours.Hourtosecond(10);
            Console.WriteLine(result12 + " Seconds");
            //#####################################
            int result13 = SumOfPolygon.SumofPolygonAngles(4);
            Console.WriteLine(result13 + " Sum");
            //#####################################

            //###### Are the Number Equal #########
            bool result14 = AreTheNumberEqual.AretheNumbersEqual(6, 5);
            Console.WriteLine("Are the Number Equal?: " + result14);
            //#####################################

            //##### Basic Variable Assignment #####
            string result15 = Basic.BasicVariableAssignments("Matt");
            Console.WriteLine(result15);
            //#####################################

            //########### Using && ################
            bool result16 = Using.Using(true, true);
            Console.WriteLine("true or false: " + result16);
            //#####################################

            //########### Basket Ball #############
            int result17 = Bask.Basketballs(2, 3);
            Console.WriteLine("Points: " + result17);
            //#####################################

            //######## Perimeter Rectangle ########
            int result18 = Rectangle.Rectangl(3, 4);
            Console.WriteLine("Rectangle " + result18);
            //#####################################

        }
    }
}


