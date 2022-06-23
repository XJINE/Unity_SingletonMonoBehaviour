# Unity_SingletonMonoBehaviour

Generic SingletonMonoBehaviour class.

## Importing

You can use Package Manager or import it directly.

```
https://github.com/XJINE/Unity_SingletonMonoBehaviour.git?path=Assets/Packages/SingletonMonoBehaviour
```

## How to Use

Make inheritance & access simply.

```csharp
public class Sample1 : SingletonMonoBehaviour<Sample1>
{
    public int value = 0;
}

Sample1.Instance.value += 1;
```
