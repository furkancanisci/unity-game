using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gameover : MonoBehaviour
{
    public static int sonpuan = 0;
    public Text sontext;

    private void Start()
    {
        sonpuan = Skor.skor;
        sontext.text = "PUAN=" + sonpuan.ToString();
    }

   
}
