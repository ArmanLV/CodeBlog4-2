using System;
using UnityEngine;

public class TypeConversation : MonoBehaviour {

    void Start () {

        // Неявное приведение
        byte b = 125;
        int i = b;
        Debug.Log(i);

        // Явное приведение
        int k = 205;
        byte n = (byte)k;
        Debug.Log(n);

        // Особенность 
        int k2 = 2048;
        byte n2 = (byte)k2;
        Debug.Log(n2);

        // Явное преобразование
        double p = 12.4;
        int m = Convert.ToInt32(p); // using System;

        // Неявное преобразование
        string s = "Hello №";
        Debug.Log(s + m);
    }

}
