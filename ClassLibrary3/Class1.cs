using System;
using ClassLibrary4;

namespace ClassLibrary3
{
    public class Level1
    {
        public void SumOfCube(int a, int b)
        {
            try
            {
                int x = GetCube(a);
                int y = GetCube(b);

                Console.WriteLine(a + b);
            }
            catch (Exception ex)
            {
                throw new Exception("First level", ex);
            }

        }

        public int GetCube(int cubeNumber)
        {
            Level2 cls = new Level2();
            return cubeNumber * cls.FindSquare(cubeNumber);
        }
    }
}
