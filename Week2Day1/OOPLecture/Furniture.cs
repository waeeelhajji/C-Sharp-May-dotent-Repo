class Furniture
{
    // Fields describe our object
    private string material;
    public string _material { get { return material; } }
    private string color;
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
    // Methods - what can our object do
    // Paint our furniture
    public void ChangeColor(string newColor)
    {
        Console.WriteLine($"Change our furniture from {color} to {newColor}");
        color = newColor;

    }
    
}