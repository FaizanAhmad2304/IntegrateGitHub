namespace ClassLibrary4
{
    public class Level2
    {
        public int FindSquare(int num)
        {
            try
            {
                int sqr = num * num;

                return DevideByZero(sqr);
            }
            catch
            {
                throw;
            }
        }

        public int DevideByZero(int num)
        {
            return num / 0;
        }
    }
}
