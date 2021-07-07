using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPlayerController : MonoBehaviour
{
    public float MoveSpeed = 1.0f;
    public GameObject bulletObject;
    private Transform myTransform;
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

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletObject, myTransform.position, Quaternion.identity);
        }

        float horizontal = Input.GetAxis("Horizontal");
        myTransform.Translate(Vector3.right * horizontal * Time.deltaTime * MoveSpeed);
    }
}
