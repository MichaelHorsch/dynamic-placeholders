namespace DynamicPlaceholders
{
    public static class PlaceholderKeyRegex
    {
        public static string DynamicKeyRegex = @"(.+)_[\d\w]{8}\-(?:[\d\w]{4}\-){3}[\d\w]{12}(?:_\d+)?";
        public static string AllowedRenderingsDynamicKeyRegex = @"(_([A-Fa-f0-9]{8}(-[A-Fa-f0-9]{4}){3}-[A-Fa-f0-9]{12}))";
    }
}
