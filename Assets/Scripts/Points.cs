using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Points : MonoBehaviour
{
    public Score score;
    public Rigidbody body;
    public GameObject tejo;
    public Transform spawnTejo;
    public float cont;
    public bool salio = false;

    private void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        body.isKinematic = false;

        if(transform.position.y < -4)
        {
            Instantiate(tejo,spawnTejo.position,spawnTejo.rotation);
            Destroy(gameObject);
        }

        if (salio == true)
        {
            cont = cont + 1 + Time.fixedDeltaTime;
        }
        else
        {
            cont = 0;
            salio = false;
        }
    }

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

        if (other.gameObject.CompareTag("Suelo"))
        {
            body.isKinematic = true;
            salio = true;
            if(cont >  200)
            {
                Instantiate(tejo, spawnTejo.position, spawnTejo.rotation);
                Destroy(gameObject);
            }
            Debug.Log("Entro");
        }
    }
}
