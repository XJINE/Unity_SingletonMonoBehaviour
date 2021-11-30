# Unity_SingletonMonoBehaviour

Generic SingletonMonoBehaviour class.

## How to Use

Make inheritance & access simply.

```csharp
public class Sample1 : SingletonMonoBehaviour<Sample1>
{
    public int value = 0;
}

Sample1.Instance.value += 1;
```