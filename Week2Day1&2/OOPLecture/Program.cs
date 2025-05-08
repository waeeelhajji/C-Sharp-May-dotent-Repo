Chair chair = new Chair("Wood", "Brown", 7.00, false,3,true);

Console.WriteLine(chair._material);
Console.WriteLine(chair._color);
// Chair.material = "Metal";
Console.WriteLine(chair._material);
chair.ChangeColor("Red");
// Console.WriteLine(Chair._color);



Chair stool = new Chair("Metal","Black",74.12,false ,1,false);
Console.WriteLine(stool._material);
stool._material ="Wood";
Console.WriteLine(stool._material);
stool.ChangeColor("Blue");

Furniture newChair = new Chair("Plastique","green",45.12,false,4,false);


// Polymorphism
List<Furniture> AllFurnitue = new List<Furniture>();
AllFurnitue.Add(chair);
AllFurnitue.Add(stool);

Table outdoorTable = new Table("Iron","Iron",700.99,true);
outdoorTable.AddItem("Vase");
outdoorTable.AddItem("Table runners");
outdoorTable.ShowItems();





