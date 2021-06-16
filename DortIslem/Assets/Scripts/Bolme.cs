using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bolme : MonoBehaviour
{
    public Text div1, div2, text;
    public InputField resultDiv, resultRest;
    public GameObject panel;
    int a, b, temp;
    void Start()
    {
        //rastgele iki sayý ata. 
        panel.SetActive(false);
        a = UnityEngine.Random.RandomRange(1, 100);
        b = UnityEngine.Random.RandomRange(1, 10);
        //Bölünen her zaman bölenden büyük olsun
        if (a < b)
        {
            temp = a;
            a = b;
            b = temp;
        }
        div1.text = a.ToString();
        div2.text = b.ToString();
    }
    void Update()
    {
        
    }
    public void Reload()
    {
        //Yeni rastgele sayýlar atama
        a = UnityEngine.Random.RandomRange(1, 100);
        b = UnityEngine.Random.RandomRange(1, 10);
        if (a < b)
        {
            temp = a;
            a = b;
            b = temp;
        }
        div1.text = a.ToString();
        div2.text = b.ToString();
        resultDiv.text = "";
        resultRest.text = "";
    }
    public void Check()
    {
        //Doðruluk kontrolü
        panel.SetActive(true);
        if (resultDiv.text == (a / b).ToString() && resultRest.text == (a % b).ToString())
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
