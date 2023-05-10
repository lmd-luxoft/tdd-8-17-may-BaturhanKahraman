namespace TDDKata
{
    public class Calc
    {
        public int Calculate(string digits)
        {
            if(digits == string.Empty)
                return 0;
            if(digits == null || 
                digits == "," || 
                digits == "\n" ||
                digits.StartsWith(',') ||
                (digits.Length>1 && (!digits.Contains(',') && !digits.Contains('\n'))) ||
                digits.EndsWith(',') ||
                digits.StartsWith('\n')||
                digits.EndsWith('\n')
                )
                return -1;
            char[] elements =digits.ToCharArray();
            int sum = 0;
            foreach(char element in elements)
            {
                if(char.IsDigit(element))
                {
                    sum += Convert.ToInt32(element.ToString());
                } 
                else if(element == ',' || element == '\n')
                    continue;
                else
                    return -1;
            }
            return sum;
        }
    }
}