namespace Laboratorium_2_20_10_2022.Services.Lab3
{
    public class Rectangle: Shape
    {
        public Rectangle(int width,int height)
        {
            Width = width;
            Height = height;
        }
        public static int operator +(Rectangle a, Rectangle b)
        {
            var result = new Rectangle(a.Width + b.Width, a.Height + b.Height);
            return result.getArea();
        }
         
        public override int getShorterSide()
        {
            return 456;
        }
    }
    //Jasiu mówi do taty żeby zrobił klasę Square która dziedziczy po Rectangle i ma dodatkowo pole side 
}
