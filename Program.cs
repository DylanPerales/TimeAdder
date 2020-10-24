using System;

namespace TimeAdder
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] timeAdder(int value1, string label1, int value2, string label2)
            {
                int seconds1 = 0;
                int seconds2 = 0;
                int totalSeconds;

                switch (label1) // Convert first value into seconds
                {
                    case "second":
                        //TODO:  VALIDATE SINGULAR VALUE
                        break;
                    case "seconds":
                        //TODO:  VALIDATE PLURAL VALUE
                        seconds1 = value1;
                        break;
                    case "minute":
                        //TODO:  VALIDATE SINGULAR VALUE
                        break;
                    case "minutes":
                        //TODO:  VALIDATE PLURAL VALUE
                        seconds1 = value1 * 60;
                        break;
                    case "hour":
                        //TODO:  VALIDATE SINGULAR VALUE
                        break;
                    case "hours":
                        //TODO:  VALIDATE PLURAL VALUE
                        seconds1 = value1 * 60 * 60;
                        break;
                    case "day":
                        //TODO:  VALIDATE SINGULAR VALUE
                        break;
                    case "days":
                        //TODO:  VALIDATE PLURAL VALUE
                        seconds1 = value1 * 24 * 60 * 60;
                        break;
                    default:
                        //TODO:  ASSIGN "FALSE" TO OBJECT ARRAY
                        break;
                }

                switch (label2) // Convert second value into seconds
                {
                    case "second":
                        //TODO:  VALIDATE SINGULAR VALUE
                        break;
                    case "seconds":
                        //TODO:  VALIDATE PLURAL VALUE
                        seconds2 = value2;
                        break;
                    case "minute":
                        //TODO:  VALIDATE SINGULAR VALUE
                        break;
                    case "minutes":
                        //TODO:  VALIDATE PLURAL VALUE
                        seconds2 = value2 * 60;
                        break;
                    case "hour":
                        //TODO:  VALIDATE SINGULAR VALUE
                        break;
                    case "hours":
                        //TODO:  VALIDATE PLURAL VALUE
                        seconds2 = value2 * 60 * 60;
                        break;
                    case "day":
                        //TODO:  VALIDATE SINGULAR VALUE
                        break;
                    case "days":
                        //TODO:  VALIDATE PLURAL VALUE
                        seconds2 = value2 * 24 * 60 * 60;
                        break;
                    default:
                        //TODO:  ASSIGN "FALSE" TO OBJECT ARRAY
                        break;
                }

                totalSeconds = seconds1 + seconds2; // Combine both broken down values

                //TODO:  BREAK DOWN totalSeconds INTO minutes, hours, days....
                object[] returnArray = new object[2]; // Create new array to store combined value and determined label;

                returnArray[0] = totalSeconds; //TODO: This will be the condensed time value
                returnArray[1] = "Parsecs"; //TODO: This will be the condensed value label

                return returnArray;
            }
        }
    }
}