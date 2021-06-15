using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Ortak : MonoBehaviour
{
    public GameObject resultPanel;
    void Start()
    {
        resultPanel.SetActive(false);
    }

    // Update is called once per frame
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
