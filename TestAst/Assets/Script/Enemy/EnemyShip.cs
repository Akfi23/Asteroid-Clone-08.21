using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class EnemyShip : Enemy 
{
    
    void Start()
    {
        _transform = GetComponent<Transform>();
        InstantiateTween();
    }

    void Update()
    {
        LookAtPlayer();
        Follow();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent<Bullet>(out Bullet bullet))
        {
            GameManager.PlayDeathEffect(this.transform.position);
            Destroy(collision.gameObject, 0);
            Destroy(gameObject, 0);
            Die();
        }
    }
}
