namespace HashTable_Test1;

public class HashTableTest
{
    private readonly int _count;
    private readonly LinkedList<Node>[] _table;

    public HashTableTest(int count)
    {
        _count = count;
        _table = new LinkedList<Node>[_count];
    }

    public void Add(string key, object value)
    {
        var hashLocation = GetHashKey(key);

        if (!_table[hashLocation].Any())
        {
            _table[hashLocation].AddFirst(new Node(key, value));
        }
        else
        {
            var node = _table[hashLocation].First;

            while (node != null)
            {
                if (node.Value.Key == key)
                {
                    node.Value.Value = value;
                    break;
                }

                node = node.Next;
            }

            _table[hashLocation].AddLast(new Node(key, value));
        }
    }

    private int GetHashKey(string key)
    {
        return key.ToCharArray()
            .Select(x => x - '0')
            .Sum() % _count;
    }
    
}