using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D _rigBod;
    public Animator animator;
    public SpriteRenderer spriteRenderer;
    
    [SerializeField]
    private float m_MoveSpeed;
    private Vector2 _movement;

    void Start()
    {
        _rigBod = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        _movement.x = Input.GetAxis("Horizontal");
        _movement.y = Input.GetAxis("Vertical");
        _rigBod.MovePosition(_rigBod.position + _movement * m_MoveSpeed * Time.fixedDeltaTime);

        Flip(_movement.x);

        float characterVelocity = Mathf.Abs(_movement.magnitude);
        animator.SetFloat("Speed", characterVelocity);


    }

    void Flip(float _Velocity)
    {
        if(_Velocity < 0.1f)
        {
            spriteRenderer.flipX = true;

        }else if (_Velocity > 0.1f) 

        {
            spriteRenderer.flipX=false; 
        }

    }
}
