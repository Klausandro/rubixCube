using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Queue<string> numbers = new Queue<string>();
        numbers.Enqueue("one");
        numbers.Enqueue("two");
        numbers.Enqueue("three");
        numbers.Enqueue("four");
        numbers.Enqueue("five");
        numbers.Dequeue();
        // A queue can be enumerated without disturbing its contents.
        foreach (string number in numbers)
        {
            Debug.Log(number);
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
