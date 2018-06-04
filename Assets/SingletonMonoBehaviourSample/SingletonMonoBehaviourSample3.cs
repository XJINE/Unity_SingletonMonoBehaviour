﻿using UnityEngine;

public class SingletonMonoBehaviourSample3 : MonoBehaviour
{
    protected virtual void Start ()
    {
        SingletonMonoBehaviourSample1.Instance.value += 1;
        Debug.Log(this.GetType().ToString() + " : " + SingletonMonoBehaviourSample1.Instance.value);
    }
}