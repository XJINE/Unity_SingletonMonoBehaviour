# Unity_SingletonMonoBehaviour

General SingletonMonoBehaviour.

## Import to Your Project

You can import this asset from UnityPackage.

- [SingletonMonoBehaviour.unitypackage](https://github.com/XJINE/Unity_SingletonMonoBehaviour/blob/master/SingletonMonoBehaviour.unitypackage)

## How to Use

### In Your Code

Make inheritance & access simply.

```csharp
public class Sample1 : SingletonMonoBehaviour<Sample1>
{
    public int value = 0;
}

Sample1.Instance.value += 1;
```

### Merit

This SingletonMonoBehaviour use bool type value ``instanciated`` when check the instance existence.
It works more faster than using null.

```csharp
private static T instance;
private static bool instanciated;

public static T Instance
{
    get
    {
        if (SingletonMonoBehaviour<T>.instanciated)
        {
            return instance;
        }

        if (SingletonMonoBehaviour<T>.instance == null)
        {
            ~
        }

        SingletonMonoBehaviour<T>.instanciated = true;

        return instance;
    }
}
```
