namespace ConsoleApplication1
{
    /// <summary>
    /// The CCircle class inherits the CShape class
    /// </summary>
    class CCircle : CShape
    {
        private int Radius;
        public CCircle(int a, int r) : base(a)
        {
            Radius = r;
        }
        public override float findArea()
        {
            float area = (float)(22 * Radius * Radius)/7;
            return area;
        }

        //Operator overloading
        public static float operator +(CCircle b, CCircle c)
        {
            float ta = b.findArea() + c.findArea();

            return ta;
        }
       
    }
}
