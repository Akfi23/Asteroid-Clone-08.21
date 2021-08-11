using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : Enemy
{
    private int _counter;
    [SerializeField] private GameObject _childMeteor;
    private void Awake()
    {
        LookAtPlayer();
    }

    void Start()
    {
        _transform = GetComponent<Transform>();        
    }

    void Update()
    {
       _transform.Translate(Vector3.one*_speed*Time.deltaTime);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent<Bullet>(out Bullet bullet))
        {
            CreateSplitMeteors();
            GameManager.PlayDeathEffect(this.transform.position);
            Destroy(collision.gameObject, 0);
            Destroy(gameObject, 0);
            Die();
        }
    }

    private void CreateSplitMeteors() 
    {
        _counter = Random.Range(0, 3);
        Vector2 position = this.transform.position;
        position += Random.insideUnitCircle * 0.5f;

        for (int i = 0; i < _counter; i++)
        {
            GameObject newChildMeteors = Instantiate(_childMeteor, position, this.transform.rotation);
            Destroy(newChildMeteors, 7);
        }
    }
}
