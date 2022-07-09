using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private float _speed;

    private Vector2 moved;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
            _rigidbody.MovePosition(Vector2.left * Time.deltaTime * _speed + _rigidbody.position);
        if (Input.GetKey(KeyCode.D))
            _rigidbody.MovePosition(Vector2.right * Time.deltaTime * _speed + _rigidbody.position);
        if (Input.GetKey(KeyCode.W))
            _rigidbody.MovePosition(Vector2.up * Time.deltaTime * _speed + _rigidbody.position);
        if (Input.GetKey(KeyCode.S))
            _rigidbody.MovePosition(Vector2.down * Time.deltaTime * _speed + _rigidbody.position);
    }
}

