using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text points;
    public int i = 0;

    void Update()
    {
        points.text = "Score: " + i;
    }
}
