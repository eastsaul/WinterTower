using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class StackTest : MonoBehaviour
{
    static void Main() 
    {
        Stack<GameObject> stack = new Stack<GameObject>();

        //stack.Push(gameObject);
        //stack.Push("�� ��°");
        //stack.Push("�� ��°");

        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());
    }

    // Start is called before the first frame update
    void Start()
    {
        Stack<GameObject> stack = new Stack<GameObject>();
        stack.Push(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
