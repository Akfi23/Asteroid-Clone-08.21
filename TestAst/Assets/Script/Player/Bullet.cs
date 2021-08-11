using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] Transform _transform;
    [SerializeField] float _speed;

    private void Awake()
    {
        _transform = GetComponent<Transform>();
    }

    private void Start()
    {
        
    }

    private void Update()
    {
        _transform.Translate(0, _speed * Time.deltaTime, 0);
    }    
}
