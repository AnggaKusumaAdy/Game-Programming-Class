using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Latihan3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int c = Jumlah(20, 40);
        Debug.Log("Hasil jumlah a dan b adalah: " + c);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    int Jumlah (int a, int b)
    {
        return a + b;
    }
}
