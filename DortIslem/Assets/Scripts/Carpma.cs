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
        panel.SetActive(false);
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
        mul1.text = a.ToString();
        mul2.text = b.ToString();
        result.text = "";
    }
    public void Check()
    {
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
