using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    public static float EulerAngZ { get; private set; }
    public static Vector3 Position { get; private set; }
    void Start()
    {
        this.gameObject.SetActive(true);
    }

    void Update()
    {
        EulerAngZ = transform.localEulerAngles.z;
        Position = transform.position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent<Meteor>(out Meteor meteor)|| collision.gameObject.TryGetComponent<EnemyShip>(out EnemyShip enemyShip))
        {
            GameManager.PlayDeathEffect(this.transform.position);
            UIManager.UIInstance.OpenRestartHUD();
            this.gameObject.SetActive(false);
        }
    }
}
