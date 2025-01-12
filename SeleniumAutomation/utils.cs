namespace Beginner
{
    public class utils
    {
        public static string RgbaToHex(string rbga) {
            var parts = rbga.Replace("rgba(", "").Replace(")", "").Split(',');

            int r = int.Parse(parts[0].Trim());
            int g = int.Parse(parts[1].Trim());
            int b = int.Parse(parts[2].Trim());

            return $"#{r:X2}{g:X2}{b:X2}";
        }
    }
}
