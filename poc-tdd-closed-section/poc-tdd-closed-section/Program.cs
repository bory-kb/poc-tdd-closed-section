namespace poc_tdd_closed_section
{

    public class ClosedSection
    {
        public static void Main()
        {
        }

        public string ReturnClosedSection(int lower , int upper)
        {
            var ret = $"[{ lower},{ upper }]";
            return (ret);
        }


    }
}