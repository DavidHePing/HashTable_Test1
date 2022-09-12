namespace HashTable_Test1;

public class Node
{
    public string Key { get; private set; }
    public object? Value { get; set; }
    
    public Node(string key, object? value)
    {
        Key = key;
        Value = value;
    }
}