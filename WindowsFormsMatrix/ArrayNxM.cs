using System;

namespace Arraynxm
{
    class ArrayNxM: ArrayNxN, ZoomArray
    {
        public ArrayNxM():base() { }
        public ArrayNxM(int n, int m): base(n,m) { }
        public override void InstanceArray()
        {
            array = new int[n, m];
            random_inp();
        }
        public void Zoom(int ind1, int ind2)
        {
            if (ind1 <= n && ind2 <= m && ind1 >= 0 && ind2 >= 0)
            {
                zoom_ar = new int[ind1, ind2];
            }
            else { 
                throw new Exception("Access Boundary Error");
            }
            for (int i = 0; i  < ind1; i ++)
            {
                for (int j = 0; j < ind2; j++)
                {
                    zoom_ar[i, j] = array[i, j];
                }
            }
        }
        public int get_zoom(int ind1, int ind2)
        {
            return zoom_ar[ind1, ind2];
        }
        public override int get_elem(int ind1, int ind2)
        {
            return base.get_elem(ind1, ind2);
        }
        public int[,] zoom_ar { get; set; }
    }
}
