using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using Random = UnityEngine.Random;
using TMPro;
using UnityEngine.SceneManagement;

public class EnemyController : MonoBehaviour
{
    private Transform myTransform;
    public GameObject explosionEffect;
    public float MoveSpeed = 2.0f;
    public TextMeshProUGUI scoreText;

    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        myTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(myTransform == null)
            return;
        
        myTransform.Translate(Vector3.down * MoveSpeed * Time.deltaTime);

        if (myTransform.position.y < -2.0f)
        {
            myTransform.position = new Vector3(Random.Range(-4.0f, 4.0f), 11.0f, 0.0f);
        }

        if (score >= 10)
        {
            SceneManager.LoadScene("win");
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("bullet"))
        {
            score += 1;
            scoreText.text = "SCORE : " + score.ToString();
            Instantiate(explosionEffect, myTransform.position, Quaternion.identity);
            myTransform.position = new Vector3(Random.Range(-4.0f, 4.0f), 11.0f, 0.0f);
            Destroy(other.gameObject);
        }
    }
}
