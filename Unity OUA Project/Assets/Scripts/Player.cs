using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody _rb;

    [SerializeField] private Joystick joystick;

    [SerializeField] private float forwardSpeed;
    [SerializeField] private float leftRightSpeed;

    [SerializeField] private Vector2 MinMaxX;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, MinMaxX.x, MinMaxX.y), transform.position.y, transform.position.z);
        _rb.velocity = new Vector3(joystick.Horizontal* leftRightSpeed * Time.deltaTime, _rb.velocity.y, forwardSpeed* Time.deltaTime);
    }
}
