using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class UpMove : MonoBehaviour
{
    public float MoveSpeed = 10f;

    private Transform myTransform;
    
    // Start is called before the first frame update
    void Start()
    {
        myTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        myTransform.Translate(MoveSpeed * Vector3.up * Time.deltaTime);

        if (myTransform.position.y > 11.0f)
        {
            Destroy(gameObject);
        }
    }
}
