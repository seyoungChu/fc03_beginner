using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
public class PlayerController : MonoBehaviour
{
    public float Speed = 1f;
    private int Count = 0;
    private Rigidbody _rigidbody;
    private float movementX;
    private float movementY;

    public TextMeshProUGUI countText;

    public GameObject youWinObject;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        Count = 0;
        SetCountText();
        youWinObject.SetActive(false);
    }

    void SetCountText()
    {
        countText.text = "Count : " + Count.ToString();
        if (Count >= 9)
        {
            youWinObject.SetActive(true);
        }
    }

    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector2 = movementValue.Get<Vector2>();
        movementX = movementVector2.x;
        movementY = movementVector2.y;
    }

    private void FixedUpdate()
    {
        if (_rigidbody == null)
        {
            return;
        }

        Vector3 moveVector3 = new Vector3(movementX, 0.0f, movementY);
        _rigidbody.AddForce(moveVector3 * Speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            Count = Count + 1;
            SetCountText();
        }
        
    }
}