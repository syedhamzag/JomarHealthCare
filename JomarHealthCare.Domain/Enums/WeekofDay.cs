namespace JomarHealthCare.Domain.Enums
{
    public static class WeekofDay
    {
        public static int GetDayID(string name)
        {
            int id = 0;
            switch (name)
            {
                case "Monday":
                    id = 1;
                    break;
                case "Tuesday":
                    id = 2;
                    break;
                case "Wednesday":
                    id = 3;
                    break;
                case "Thursday":
                    id = 4;
                    break;
                case "Friday":
                    id = 5;
                    break;
                case "Saturday":
                    id = 6;
                    break;
                case "Sunday":
                    id = 7;
                    break;
                default:
                    Console.WriteLine("Not a vowel");
                    break;
            }
            return id;
        }
    }

}
