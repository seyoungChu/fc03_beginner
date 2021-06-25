using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthOrbit : MonoBehaviour
{
    private float rotateAngle = 0f;
    private float selfRotateAngle = 0f;
    [SerializeField] private float rotateSpeed = 1f;
    [SerializeField] private float rotateRadius = 1.5f;

    [SerializeField] private float selfRotateSpeed = 100f;
    // Update is called once per frame
    void Update()
    {
        float xPosition = rotateRadius * Mathf.Sin(rotateAngle);
        float zPostion = rotateRadius * Mathf.Cos(rotateAngle);

        transform.localPosition = new Vector3(xPosition, 0f, zPostion);

        rotateAngle += rotateSpeed * Time.deltaTime;

        selfRotateAngle = selfRotateSpeed * Time.deltaTime;
        transform.Rotate(Vector3.up, selfRotateAngle);

    }
}
