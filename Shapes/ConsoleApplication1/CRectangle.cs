namespace ConsoleApplication1
{
    class CRectangle : CShape,IRectangle
    {
        /// <summary>
        /// CRectangle class implements the IRectangle interface and inherits the CShape class
        /// </summary>
        private int Length;
        private int Breadth;
        public CRectangle(int a, int l, int b) : base(a)
        {
            Length = l;
            Breadth = b;
        }
        public override float findArea()
        {
            int area = Length * Breadth;
            return area;
        }

        //Operator overloading
        public static float operator+ (CRectangle b, CRectangle c)
        {
            float ta = b.findArea() + c.findArea();

            return ta;
        }
    }
}
