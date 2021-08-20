using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Latihan2 : MonoBehaviour
{
    public int A;
    public int B;
    [Range(1, 10)]
    public int C;
    // Start is called before the first frame update
    void Start()
    {
        int total = (A + B) * C;
        Debug.Log("Total: " + total);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
