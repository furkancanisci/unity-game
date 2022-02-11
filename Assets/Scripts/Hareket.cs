using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Hareket : MonoBehaviour
{
    Vector3 y�n;
    public float h�z;
    public float h�z�;
    public Zeminolustur zemolusturscr;
    public static bool d�st�;
    public float ivme;

    void Start()
    {
        y�n = Vector3.forward;
        d�st� = false;
    }

    void Update()
    {
        
        if(transform.position.y<= 0.5f)
            {
            d�st� = true;
            SceneManager.LoadScene(2);
        }
        if(d�st� == true)
        {
            return;
        }
        if(Input.GetMouseButtonDown(0))
        {
            if(y�n.x == 0)
            {
                y�n = Vector3.left;
            }

            else
            {
                y�n = Vector3.forward;
            }
            h�z� += ivme * Time.deltaTime;
            h�z += h�z� * 2;
        }  
    }
    private void FixedUpdate()
    {
        Vector3 hareketi = y�n * Time.deltaTime * h�z;
        transform.position += hareketi;
    }

    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.tag == "zemin")
        {
            Skor.skor++;
            collision.gameObject.AddComponent<Rigidbody>();
            zemolusturscr.zeminolusturan();
            StartCoroutine(Zeminisil(collision.gameObject));
        }
       else
        {

        }
    }
    IEnumerator Zeminisil(GameObject Silinecekzemin)
    {
        yield return new WaitForSeconds(3f);
        Destroy(Silinecekzemin);

    }
}

