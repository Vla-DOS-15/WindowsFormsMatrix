using System;


namespace Arraynxm
{
    class ArrayNxN : Array
    {
        public ArrayNxN(): base() { }
        public ArrayNxN(int n, int m) : base(n)
        {
            this.m = m;
        }
        public override void InstanceArray()
        {
            if (n != m)
            {
                throw new Exception("NxN array but n!=m");
            }
            array = new int[n, m];
            random_inp();
        }
        protected void random_inp()
        {
            var x = new Random();
            for (int i = 0; i <n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = x.Next(-100, 100);
                }
            }
        }
        public override int get_elem(int ind1,int ind2)
        {
            return array[ind1, ind2];
        }
        protected int[,] array;
        public int m { get; set; }
    }
}
