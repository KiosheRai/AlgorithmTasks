using System.Text.RegularExpressions;

namespace Hash
{
    public static class Validator
    {
        public static bool isPhone(string str)
        {
            var rg = new Regex(@"^(\+375+(24|25|29|33|44)+([0-9]){7})$");
            if (!rg.IsMatch(str))
                return false;
            return true;
        }

        public static bool isEmptyString(string str)
        {
            if (str.Trim().Length == 0)
                return true;
            return false;
        }
    }
}
