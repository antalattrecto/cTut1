using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketCalc
{
    class RocketCalc
    {
        static void Main(string[] args)
        {
            double res1;
            double res2;
            double res3;
            double d;
            double g = 9.81; //    m/s2
            double m;        //kg mass of rocket with empty engine
            double r = 1.22; // density of air - kg/m3
            double cd = 0.75; // drag coefficient
            double v; //descent velocity chosen
            double pi = 3.141592;
            double tubedia;
            double tubelength;
            double finA;
            int userChoice;
            double rocketLength;
            double motorTrust;
            double liftOffWeight;
            bool safeOrNot;

            Console.WriteLine("Select:\n 1 for tube length \n 2 for Calculating Parachute size \n 3 for fin calculations \n 4 for lift-off weight trust ration");
            userChoice = Convert.ToInt32(Console.ReadLine());

        

            if (userChoice == 1)
            {

                // rocket length

                Console.Write("Type in tube diameter in cm:");
                tubedia = Convert.ToDouble(Console.ReadLine());

                rocketLength = 12.5 * tubedia;

                Console.WriteLine("Ideal rocket length is: {0} cm", rocketLength);
                Console.ReadLine();

            }

            else if (userChoice == 2)
            {
                //round parachute

                Console.Write("Type in rocket mass in g:");
                m = Convert.ToDouble(Console.ReadLine()) / 1000;



                Console.Write("Type in descent velocity in m/s (ideal is between 3.4-4.5):");
                v = Convert.ToDouble(Console.ReadLine());



                res1 = 8 * m * g;
                res2 = pi * r * cd * Math.Pow(v, 2);
                res3 = res1 / res2;

                d = Math.Sqrt(res3);


                Console.WriteLine("Round shaped parachute diameter is: {0} cm. Radius is: {1} cm", d, d / 2);
                Console.ReadLine();
            }

            else if (userChoice == 3)

            {

                //fin area

                Console.Write("Body tube diameter in cm:");
                tubedia = (Convert.ToDouble(Console.ReadLine())) * 0.3937;

                Console.Write("Tub length in cm: ");
                tubelength = (Convert.ToDouble(Console.ReadLine())) * 0.3937;

                finA = ((tubedia + 0.5) * tubelength) / 6;

                Console.WriteLine("Fin Area: {0} cm2", finA * 6.45);
                Console.ReadLine();

            }

            else if (userChoice ==4)
            {

                // trust weight ration

                Console.Write("Rocket mass in g:");
                m = Convert.ToDouble(Console.ReadLine());

                Console.Write("Average motor trust: ");
                motorTrust = Convert.ToDouble(Console.ReadLine());
                liftOffWeight = motorTrust * 10;

                if (m < liftOffWeight)
                {
                    safeOrNot = true;
                }

                else
                {
                    safeOrNot = false;
                }

                Console.WriteLine("Safe rocket weight is: {0}. Your rocket weight is: {1}. Safe to fly: {2}", liftOffWeight, m, safeOrNot );
                Console.ReadLine();
            }

        }
    }
}
