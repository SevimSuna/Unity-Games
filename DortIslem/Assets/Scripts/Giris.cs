using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Giris : MonoBehaviour
{
    public GameObject panel, playButton, closeButton;
    void Start()
    {
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Play()
    {
        panel.SetActive(true);
        playButton.SetActive(false);
    }
    public void Close()
    {
        panel.SetActive(false);
        playButton.SetActive(true);
    }
    public void Sum()
    {
        SceneManager.LoadScene(1);
    }
    public void Dif()
    {
        SceneManager.LoadScene(2);
    }
    public void Div()
    {
        SceneManager.LoadScene(4);
    }
    public void Mul()
    {
        SceneManager.LoadScene(3);
    }
}
