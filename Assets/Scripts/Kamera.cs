using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamera : MonoBehaviour
{
    public Transform topunkonumu;
    Vector3 fark;
    void Start()
    {
        fark = transform.position - topunkonumu.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Hareket.düstü == false)
        {
            transform.position = topunkonumu.position + fark;
        }
      
    }
}
