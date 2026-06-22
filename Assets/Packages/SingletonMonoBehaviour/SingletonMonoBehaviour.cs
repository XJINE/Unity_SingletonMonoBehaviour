using UnityEngine;

// NOTE:
// Prevents instantiation when the application quits.
// Separated from the generic class because [RuntimeInitializeOnLoadMethod] cannot be used inside generic classes.
// Reset on play start so the flag does not survive when Domain Reload is disabled in Enter Play Mode Settings.
internal static class SingletonMonoBehaviourQuit
{
    internal static bool Quitting;

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
    private static void Reset()
    {
        Quitting = false;
    }
}

public class SingletonMonoBehaviour<T> : MonoBehaviour where T : SingletonMonoBehaviour<T>
{
    private static T _instance;
    public static T Instance
    {
        get
        {
            if (SingletonMonoBehaviourQuit.Quitting)
            {
                return null;
            }

            if (Instantiated)
            {
                return _instance;
            }

            _instance = (T)FindAnyObjectByType(typeof(T));

            if (_instance != null)
            {
                return _instance;
            }

            var gameObject = new GameObject(typeof(T).ToString());

            _instance = gameObject.AddComponent<T>();

            return _instance;
        }
    }

    // NOTE:
    // Used to check if the instance already exists without instantiating it.
    public static bool Instantiated => _instance != null;

    protected virtual void Awake()
    {
        if (_instance == null)
        {
            _instance = (T)this;
        }

        else if (_instance != this)
        {
            Debug.LogWarning($"Singleton {typeof(T)} is already exists.");
            Destroy(this);
        }
    }

    protected virtual void OnApplicationQuit()
    {
        SingletonMonoBehaviourQuit.Quitting = true;
    }

    protected virtual void OnDestroy()
    {
        if (_instance != this)
        {
            return;
        }

        _instance = null;
    }
}