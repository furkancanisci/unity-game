using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Zeminolustur : MonoBehaviour
{ 
    public GameObject sonzemin;
    void Start() 
    { 
        for (int i = 0; i < 20; i++) 
      zeminolusturan(); 
    }
   public void zeminolusturan()
    {
        Vector3 yonu;
        if (Random.Range(0, 2) == 0)
        {
            yonu = Vector3.left;
        }
        else {
            yonu = Vector3.forward;
        }
        sonzemin = Instantiate(sonzemin, sonzemin.transform.position + yonu, sonzemin.transform.rotation);

        }
}
