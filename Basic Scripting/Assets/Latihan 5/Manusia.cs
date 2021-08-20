using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manusia : MonoBehaviour
{
    public void Makan()
    {
        Debug.Log("Energi berada dibawah batas, segera makan!");
    }
    public void Tidur()
    {
        Debug.Log("Anda mengalami kelelahan, segera tidur!");
    }
}
