namespace ConsoleApplication1
{
    
  /// <summary>
  /// Parent class, an abstract class for the purpose of explaing Overriding concepts
  /// </summary>
    abstract class CShape
    {
        protected int Id;
        public static int ShapeCount;
        public static float totalArea;

        public CShape()
        {
            Id = 0;
            ShapeCount++;
        }
        public CShape(int a)
        {
            Id = a;
            ShapeCount++;
        }
        public abstract float findArea();
        public void setTotalArea(float a)
        {
            totalArea += a;
        }
        public float getTotalArea()
        {
            return totalArea;
        }
        public int getCount()
        {
            return ShapeCount;
        }
    }
}
