using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildMeteor : Meteor
{
    private void Awake()
    {
        LookAtPlayer();

    }
    private void Start()
    {
        _transform = GetComponent<Transform>();
    }

    private void Update()
    {
        _transform.Translate(Vector3.one * _speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent<Bullet>(out Bullet bullet))
        {
            Die();
            GameManager.PlayDeathEffect(this.transform.position);
            Destroy(collision.gameObject, 0);
            Destroy(gameObject, 0);
        }
    }
}
