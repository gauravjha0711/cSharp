using System;
using System.Collections;
public class MyCollection : IEnumerable
{
    int[] data = {1,2,3,4,5};
    public IEnumerator GetEnumerator()
    {
        return data.GetEnumerator();
    }
    
}