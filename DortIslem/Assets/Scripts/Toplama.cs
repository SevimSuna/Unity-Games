using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Toplama : MonoBehaviour
{
    //rastgele iki say� ata. 
    public Text sum1, sum2, text;
    public InputField result;
    public GameObject panel;
    int a, b, temp;
    void Start()
    {
        panel.SetActive(false);
        a = UnityEngine.Random.RandomRange(1, 100);
        b = UnityEngine.Random.RandomRange(1, 100);
        //�stteki de�er hep b�y�k olan olsun
        if (a < b)
        {
            temp = a;
            a = b;
            b = temp;
        }
        sum1.text = a.ToString();
        sum2.text = b.ToString();
    }
    void Update()
    {
        
    }
    public void Reload()
    {
        //Yeni rastgele say�lar atama
        a = UnityEngine.Random.RandomRange(1, 100);
        b = UnityEngine.Random.RandomRange(1, 100);
        if (a < b)
        {
            temp = a;
            a = b;
            b = temp;
        }
        sum1.text = a.ToString();
        sum2.text = b.ToString();
        result.text = "";
    }
    public void Check()
    {
        //Do�ruluk kontrol�s
        panel.SetActive(true);
        if(result.text == (a+b).ToString())
        {
            text.text = "Dogru";
        }
        else
        {
            text.text = "Yanlis";
        }
        Reload();
    }
}
