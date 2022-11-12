public class Circle 
{
    public double radius;
    public double PI = 3.14;
    public Circle()
    {
        
    }
    public Circle(double radius)
    {
        this.radius = radius;
    }
    public double GetRadius()
    {
        return this.radius;
    }
    public void SetRadius(double radius)
    {
        this.radius = radius;
    }
    public double GetArea()
    {
        return this.radius * this.radius;
    }
    public double GetCircumference()
    {
        return 2 * PI * this.radius;
    }
    public override string? ToString()
    {
        return base.ToString();
    }
}