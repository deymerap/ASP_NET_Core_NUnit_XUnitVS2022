namespace LibraryDpm
{
    public class Operation
    {
        public int Sum(int Number1, int Number2) => Number1 + Number2;

        public bool IsValueEven(int vNumber)
        {
            return vNumber % 2 == 0;
        }

        public double SumDecimal(double Number1, double Number2) => Number1 + Number2;

        public List<int> ListOddNumbers(int vMin, int vMax)
        {
            List<int> list = new List<int>();   

            for(int i = vMin; i <= vMax; i++)
            {
                if(i%2!=0)
                    list.Add(i);
            }

            return list;
        }



    }


}