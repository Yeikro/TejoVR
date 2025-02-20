using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Points : MonoBehaviour
{
    public Score score;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Mecha"))
        {
            score.i = score.i + 3;
            Debug.Log("entro mecha");
        }

        if (other.gameObject.CompareTag("Bocina"))
        {
            score.i = score.i + 6;
            Debug.Log("entro bocina");
        }
    }
}
