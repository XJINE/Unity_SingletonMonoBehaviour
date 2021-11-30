using UnityEngine;

public class ReferenceSample : MonoBehaviour
{
    private void Start ()
    {
        SingletonMonoBehaviourSample.Instance.value += 1;
        Debug.Log(GetType() + " : " + SingletonMonoBehaviourSample.Instance.value);
    }
}