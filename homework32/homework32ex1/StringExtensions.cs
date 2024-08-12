public static class StringExtensions
{
    public static string MyToUpper(this string input)
    {
        return input.ToUpper();
    }

    public static string MyToLower(this string input)
    {
        return input.ToLower();
    }

    public static string MyTrim(this string input)
    {
        return input.Trim();
    }

    public static bool MyIsNullOrEmptyWhiteSpace(this string input)
    {
        return string.IsNullOrWhiteSpace(input);
    }
}
