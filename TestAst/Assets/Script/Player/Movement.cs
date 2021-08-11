using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    [SerializeField] private Transform _transform;
    [SerializeField] private float _speed;
    private float _currentSpeed;
    private Vector2 _moveDirection;
    private float _rotateDirection;

    private void Awake()
    {
        _transform = GetComponent<Transform>();
    }

    private void Start()
    {
    }

    private void Update()
    {
        MoveForward(_moveDirection,_currentSpeed);
        RotateAround(_rotateDirection);
    }

    public void OnMove(InputAction.CallbackContext context) 
    {
        //_currentSpeed = Mathf.Lerp(0, _speed, 3);
        _moveDirection = context.ReadValue<Vector2>();
    }
   
    public void OnRotate(InputAction.CallbackContext context)
    {
        _rotateDirection = context.ReadValue<float>();
    }

    private void MoveForward(Vector2 direction,float currentSpeed)
    {
        _transform.Translate(direction*_speed*Time.deltaTime);
    }

    private void RotateAround(float rotateDirection)
    {
        _transform.Rotate(0, 0, rotateDirection);
    }    
}
