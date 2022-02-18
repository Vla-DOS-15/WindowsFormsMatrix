
namespace Arraynxm
{
    class ArraysContainer
    {
        public ArraysContainer() {
            array = new ArrayNxM();
        }
        public ArraysContainer(int n, int m)
        {
            array = new ArrayNxM(n, m);
        }
        public void Zoom(int n, int m)
        {
            array.Zoom(n, m);
        }
        public ArrayNxM array { get; set; }
    }
}
