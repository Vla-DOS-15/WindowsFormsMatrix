using System;


namespace Arraynxm
{
     abstract class Array
     {
        public Array() { }
        public Array(int n)
        {
            this.n = n;
        }
        public virtual void InstanceArray()
        {
            array = new int[n];
        }
        public virtual int get_elem(int ind, int t=0)
        {
            if(ind >= 0 && ind <= n)
            {
                return array[ind];
            }
            else
            {
                throw new Exception("Array boundary acces");
            }
        }
        private int[] array;
        public int n { get; set; }
    }
}
