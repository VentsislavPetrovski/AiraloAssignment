namespace AiraloAssignment.APISetup.Helpers
{
    public static class HelperMethods
    {
        private static readonly Random Random = new();

        public static string RandomNumberString(int length)
        {
            const string chars = "0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[Random.Next(s.Length)]).ToArray());
        }
    }
}
