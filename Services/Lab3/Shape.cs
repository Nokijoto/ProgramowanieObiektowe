namespace Laboratorium_2_20_10_2022.Services.Lab3
{
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int getArea()
        {
            return Width * Height;
        }
        public int getArea(int x)
        {
            return Width * Height *x;
        }
        public int getArea(double x)
        {
            return Width * Height * (int)x;
        }
        public virtual int getShorterSide()
        {
            //if (Width < Height)
            //{
            //    return Width;
            //}
            //return Height; 
            return new List<int>() { Width, Height }.Min();
        }
        
    }
}
