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
        panel.SetActive(false);
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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Reload()
    {
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
