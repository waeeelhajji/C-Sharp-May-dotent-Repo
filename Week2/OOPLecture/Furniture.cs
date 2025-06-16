abstract  class Furniture
{
    // Fields describe our object
    protected string material;
    public string _material { get { return material; } set {material = value;} }
    protected string color;
    public string _color { get { return color; } }
    public double price;
    public bool outdoor;
    // Constructor 
    public Furniture(string m, string c, double p, bool o)
    {
        material = m;
        color = c;
        price = p;
        outdoor = o;
    }
    public Furniture(string m, string c, double p)
    {
        material = m;
        color = c;
        price = p;
        outdoor = true;
    }
    // Methods - what can our object do
    // Paint our furniture
    public virtual void ChangeColor(string newColor)
    {
        Console.WriteLine($"Change our furniture from {color} to {newColor}");
        color = newColor;

    }
    
}