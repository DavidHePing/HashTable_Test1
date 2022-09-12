namespace HashTable_Test1;

public class HashTableTest
{
    private readonly int _count;
    private List<Node>[] _table;

    public HashTableTest(int count)
    {
        _count = count;
        _table = new List<Node>[_count];
    }

    public int GetHashKey(string key)
    {
        return key.ToCharArray()
            .Select(x => x - '0')
            .Sum() % _count;
    }
    
}