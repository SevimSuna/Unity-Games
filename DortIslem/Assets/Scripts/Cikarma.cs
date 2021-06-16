using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cikarma : MonoBehaviour
{
    public Text dif1, dif2, text;
    public InputField result;
    public GameObject panel;
    int a, b, temp;
    void Start()
    {
        //rastgele iki sayý ata
        panel.SetActive(false);
        a = UnityEngine.Random.RandomRange(1, 100);
        b = UnityEngine.Random.RandomRange(1, 100);
        //Üstteki deðer hep büyük olan olsun
        if (a < b)
        {
            temp = a;
            a = b;
            b = temp;
        }
        dif1.text = a.ToString();
        dif2.text = b.ToString();
    }
    void Update()
    {
        
    }
    public void Reload()
    {
        //Yeni rastgele sayýlar atama
        a = UnityEngine.Random.RandomRange(1, 100);
        b = UnityEngine.Random.RandomRange(1, 100);
        if (a < b)
        {
            temp = a;
            a = b;
            b = temp;
        }
        dif1.text = a.ToString();
        dif2.text = b.ToString();
        result.text = "";
    }
    public void Check()
    {
        //Doðruluk kontrolü
        panel.SetActive(true);
        if (result.text == (a - b).ToString())
        {
            text.text = "Dogru";
        }
        else
        {
            print((a - b).ToString());
            print(result);
            text.text = "Yanlis";
        }
        Reload();
    }
}
