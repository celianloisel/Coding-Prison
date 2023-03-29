using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D _rigBod;
    
    [SerializeField]
    private float m_MoveSpeed;
    private Vector2 _movement;

    void Start()
    {
        _rigBod = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        _movement.x = Input.GetAxis("Horizontal");
        _movement.y = Input.GetAxis("Vertical");
        _rigBod.MovePosition(_rigBod.position + _movement * m_MoveSpeed * Time.fixedDeltaTime);
    }
}