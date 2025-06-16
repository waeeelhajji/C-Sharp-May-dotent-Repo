class Chair : Furniture
{
    // Fields
    int numLegs;
    bool hasArms;



    // Constuctor
    public Chair(string m, string c, double p, bool o,int nl , bool ha) : base(m,c,p,o)
    {
        numLegs = nl;
        hasArms = ha;
    }
    // Overriding
    public override void ChangeColor(string newColor)
    {
        Console.WriteLine($"Change our Chair from {color} to {newColor}");
        color = newColor;
    }


}