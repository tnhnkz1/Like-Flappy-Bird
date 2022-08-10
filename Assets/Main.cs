using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    public GameObject Pipe;
    public GameObject Over_PNL;

    int Score = 0;

    public TMPro.TextMeshProUGUI Score_TXT;

    void Start()
    {
        InvokeRepeating("Add_Pipe", 3.0f, 2.0f);
        Score_TXT.text = Score.ToString();
    }

    public void Increase_Score(int value)
    {
        Score += value;
        Score_TXT.text = Score.ToString();
    }

    public void Play_Again()
    {
        SceneManager.LoadScene("Scenes/Flappy Bird");
        Time.timeScale = 1.0f;
    }

    public void Quit()
    {
        Application.Quit();
    }

    void Add_Pipe()
    {
        GameObject new_Pipe = Instantiate(Pipe);
    }
}


