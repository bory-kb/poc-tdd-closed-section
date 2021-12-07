namespace poc_tdd_closed_section
{

    public class ClosedSection
    {
        public static void Main()
        {
        }

        public static string ReturnClosedSection(int bottomPorint , int endPoint)
        {
            var ret = $"[{ bottomPorint},{ endPoint }]";
            return (ret);
        }


    }
}