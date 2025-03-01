using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public Text points;
    public int i = 0;
    public GameObject gano;


    void Update()
    {
        points.text = "Score: " + i;

        if(i >= 15)
        {
            gano.SetActive(true);
        }
    }

    public void Retry()
    {
        SceneManager.LoadScene(0);
    }
}
