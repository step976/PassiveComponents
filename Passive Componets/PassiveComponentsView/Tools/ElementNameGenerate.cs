namespace PassiveComponentsView.Tools
{
    internal static class ElementNameGenerate
    {
        private static int _rCount;
        private static int _cCount;
        private static int _iCount;

        public static string GenerateNameResistor()
        {
            _rCount++;
            return "R" + _rCount;
        }

        public static string GenerateNameInductor()
        {
            _iCount++;
            return "I" + _iCount;
        }

        public static string GenerateNameCapacitor()
        {
            _cCount++;
            return "C" + _cCount;
        }
    }
}