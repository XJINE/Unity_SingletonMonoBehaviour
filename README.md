# Unity_SingletonMonoBehaviour

General SingletonMonoBehaviour.

## Import to Your Project

You can import this asset from UnityPackage.

- [SingletonMonoBehaviour.unitypackage](https://github.com/XJINE/Unity_SingletonMonoBehaviour/blob/master/SingletonMonoBehaviour.unitypackage)

## Merit

This SingletonMonoBehaviour use bool type value ``instanciated`` when check the instance existence.
It works more faster than using null.

```
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
