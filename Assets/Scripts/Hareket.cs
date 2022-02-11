using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Hareket : MonoBehaviour
{
    Vector3 yön;
    public float hýz;
    public float hýzý;
    public Zeminolustur zemolusturscr;
    public static bool düstü;
    public float ivme;

    void Start()
    {
        yön = Vector3.forward;
        düstü = false;
    }

    void Update()
    {
        
        if(transform.position.y<= 0.5f)
            {
            düstü = true;
            SceneManager.LoadScene(2);
        }
        if(düstü == true)
        {
            return;
        }
        if(Input.GetMouseButtonDown(0))
        {
            if(yön.x == 0)
            {
                yön = Vector3.left;
            }

            else
            {
                yön = Vector3.forward;
            }
            hýzý += ivme * Time.deltaTime;
            hýz += hýzý * 2;
        }  
    }
    private void FixedUpdate()
    {
        Vector3 hareketi = yön * Time.deltaTime * hýz;
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

