using System;
using UnityEngine.Events;

[System.Serializable]
public class AnimationEvent : UnityEvent<string>
{
    // Start is called before the first frame update
    void Start()
    {
        Console.WriteLine("Hi");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
