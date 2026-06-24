using System;
using UnityEngine;

public class TriggerEvent : MonoBehaviour
{
    Action onEnter;

    void Start()
    {
        onEnter += SayBoom;
    }
    void OnTriggerEnter(Collider other)
    {
        onEnter?.Invoke(); // Call Invoke only if OnEnter
        {
            
        }
    }

    void SayBoom()
    {
        Debug.Log("Booooooom!");
    }
}
