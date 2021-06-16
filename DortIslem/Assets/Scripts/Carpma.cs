using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Carpma : MonoBehaviour
{
    public Text mul1, mul2, text;
    public InputField result;
    public GameObject panel;
    int a, b, temp;
    void Start()
    {
        //rastgele iki say� ata. 
        panel.SetActive(false);
        a = UnityEngine.Random.RandomRange(1, 100);
        b = UnityEngine.Random.RandomRange(1, 10);
        //�stteki de�er hep b�y�k olan olsun
        if (a < b)
        {
            temp = a;
            a = b;
            b = temp;
        }
        mul1.text = a.ToString();
        mul2.text = b.ToString();
    }
    void Update()
    {
        
    }
    public void Reload()
    {
        //Yeni rastgele say�lar atama
        a = UnityEngine.Random.RandomRange(1, 100);
        b = UnityEngine.Random.RandomRange(1, 10);
        if (a < b)
        {
            temp = a;
            a = b;
            b = temp;
        }
        mul1.text = a.ToString();
        mul2.text = b.ToString();
        result.text = "";
    }
    public void Check()
    {
        //Do�ruluk kontrol�
        panel.SetActive(true);
        if (result.text == (a * b).ToString())
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
