using UnityEngine;
using System.Collections;

public class DestroyEffect : MonoBehaviour
{
    public bool isAutoDestroy = false;
    void Start()
    {
        if (isAutoDestroy)
        {
            Destroy(transform.gameObject, 1f);
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.X) || Input.GetKeyDown(KeyCode.C))
        {
            Destroy(transform.gameObject);
        }
    }
}