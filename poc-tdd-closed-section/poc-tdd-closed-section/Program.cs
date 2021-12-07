namespace poc_tdd_closed_section
{

    public class ClosedSection
    {
        public int _lower;
        public int _upper;

        public ClosedSection(int lower, int upper)
        {
            _lower = lower;
            _upper = upper;
        }

        public static void Main()
        {
        }

        public  string ReturnClosedSection()
        {
            var ret = $"[{ _lower},{ _upper }]";
            return (ret);
        }


    }
}