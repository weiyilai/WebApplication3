namespace WebApplication3.Models
{
    public class ScaleConverter
    {
        private char[] chars;

        private Dictionary<char, int> dict;

        public int length;

        public ScaleConverter(string scaleString = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ")
        {
            chars = scaleString.ToCharArray();
            dict = ToCharDict(this.chars);
            length = chars.Length;
        }

        public string ToCurrent(long num)
        {
            string curr = string.Empty;
            while (num >= length)
            {
                curr = chars[num % length] + curr;
                num = num / length;
            }
            curr = chars[num] + curr;
            return curr;
        }

        public long ToInt32(string current)
        {
            double num = 0;
            for (int i = 0; i < current.Length; i++)
            {
                num += dict[current[i]] * Math.Pow(length, current.Length - 1 - i);
            }
            return Convert.ToInt64(num);
        }

        private static Dictionary<char, int> ToCharDict(char[] chars)
        {
            var dic = new Dictionary<char, int>();
            for (int i = 0; i < chars.Length; i++)
            {
                dic.Add(chars[i], i);
            }
            return dic;
        }
    }
}
