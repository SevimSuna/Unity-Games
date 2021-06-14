using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tahmin : MonoBehaviour
{
    public Text soru, tahmin;
    public GameObject up, down, yes, no, ok;
    private bool evetMi = false;
    private bool isUp = false;
    private bool isDown = false;
    int minSayi = 1;
    int maxSayi = 100;
    int tahminSayisi;
    int sayac = 1;
    void Start()
    {
        soru.text = "Tahmin oyunu oynamak ister misin?";
        tahmin.text = " ";
        up.SetActive(false);
        down.SetActive(false);
        ok.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Yes()
    {
        if(!evetMi)
        {
            evetMi = true;
            soru.text = "O zaman aklýndan bir sayi tut!";
            tahmin.text = "";
            print(evetMi);
        }
        else if(evetMi)
        {
            evetMi = false;
            yes.SetActive(false);
            no.SetActive(false);
            up.SetActive(true);
            down.SetActive(true);
            ok.SetActive(true);
            soru.text = "Tuttuðun sayý:";
            Hesapla();
        }
    }
    public void No()
    {
        Application.Quit();
    }
    public void Yukari()
    {
        isUp = true;
        sayac++;
        Hesapla();
    }
    public void Asagi()
    {
        isDown = true;
        sayac++;
        Hesapla();
    }
    public void Tamam()
    {
        soru.text = sayac + ". tahminde buldum. Bir daha oynamak ister misin?";
        minSayi = 1;
        maxSayi = 100;
        sayac = 0;
        yes.SetActive(true);
        no.SetActive(true);
        up.SetActive(false);
        down.SetActive(false);
        ok.SetActive(false);

    }
    void Hesapla()
    {
        if(isUp)
        {
            minSayi = tahminSayisi;
            isUp = false;
        }
        else if(isDown)
        {
            maxSayi = tahminSayisi;
            isDown = false;
        }
        tahminSayisi = (maxSayi + minSayi) / 2;
        tahmin.text = tahminSayisi.ToString();
    }
}
