using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private EnemyShip _enemyShip;
    [SerializeField] private Meteor _meteor;
    [SerializeField] private float _spawnDistance;

    [Range(0.0f, 90.0f)]
    [SerializeField] private float _trajectoryVariance = 15.0f;
    private bool isSpawning = true;

    void Start()
    {
        StartCoroutine(SpawnEnemyShip());
        StartCoroutine(SpawnAsteroid());
    }

    void Update()
    {

    }

    private IEnumerator SpawnEnemyShip()
    {
        while (isSpawning == true)
        {            
            yield return new WaitForSeconds(10);
            Vector2 spawnDirection = Random.insideUnitCircle.normalized;
            Vector3 spawnPoint = spawnDirection * this._spawnDistance;

            spawnPoint += this.transform.position;

            float variance = Random.Range(-this._trajectoryVariance, this._trajectoryVariance);
            Quaternion rotation = Quaternion.AngleAxis(variance, Vector3.forward);

            EnemyShip newShip = Instantiate(_enemyShip, spawnPoint, rotation);

            Vector2 trajectory = rotation * -spawnDirection;            
        }
    }

    private IEnumerator SpawnAsteroid()
    {
        while (isSpawning == true)
        {
            yield return new WaitForSeconds(3);
            Vector2 spawnDirection = Random.insideUnitCircle.normalized;
            Vector3 spawnPoint = spawnDirection * this._spawnDistance;
            
            spawnPoint += this.transform.position;

            float variance = Random.Range(-this._trajectoryVariance, this._trajectoryVariance);
            Quaternion rotation = Quaternion.AngleAxis(variance, gameObject.transform.rotation.eulerAngles);
            
            Meteor newAsteroid = Instantiate(_meteor, spawnPoint, rotation);

            Vector2 trajectory = rotation * -spawnDirection;
            Destroy(newAsteroid.gameObject, 7);
        }
    }
}
