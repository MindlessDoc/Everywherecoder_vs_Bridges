using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private float _speed;
    [SerializeField] private float _correct = 1;

    private Animator _animator;

    private Vector2 moved;
    private bool right;

    void Start()
    {
        _animator = GetComponent<Animator>();
    }
    
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Move(Vector2.left * Time.deltaTime * _speed + _rigidbody.position);
            if (right)
            {
                Flip();
            }
        }
        else if (Input.GetKey(KeyCode.D))
        {
            Move(Vector2.right * Time.deltaTime * _speed + _rigidbody.position);
            if (!right)
            {
                Flip();
            }
        }
        else if (Input.GetKey(KeyCode.W))
        {
            Move(Vector2.up * Time.deltaTime * _speed + _rigidbody.position);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            Move(Vector2.down * Time.deltaTime * _speed + _rigidbody.position);
        }
        else
        {
            _animator.SetBool("isRunning", false);
        }
    }

    private void Flip()
    {
        right = !right;
        Vector3 localScale = transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
        if (right)
        {
            Move(Vector2.right * _correct + _rigidbody.position);
        }
        else
        {
            Move(Vector2.right * -_correct + _rigidbody.position);
        }

    }

    private void Move(Vector2 vec)
    {
        _rigidbody.MovePosition(vec);
        _animator.SetBool("isRunning", true);
    }
}

