
interface IDecorate 
{
    // add a filed (auto-implemented property)
    int numberOfItems {get;set;}
    List<string> AllItems{get;set;}

    // Add a method
    void AddItem(string intem);
    void ShowItems();
}