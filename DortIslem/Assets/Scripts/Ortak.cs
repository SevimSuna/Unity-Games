using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Ortak : MonoBehaviour
{
    //Her sahnede ortak olarak kullan�lacak ana ekrana d�n�� butonu ve sonu� paneli.
    public GameObject resultPanel;
    void Start()
    {
        resultPanel.SetActive(false);
    }
    void Update()
    {
        
    }
    public void Home()
    {
        SceneManager.LoadScene(0);
    }
    public void Close()
    {
        resultPanel.SetActive(false);
    }
}
