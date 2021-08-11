using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Enemy : MonoBehaviour
{
    [SerializeField] protected GameObject _player;  
    [SerializeField] protected Transform _transform;
    [SerializeField] protected Ship _ship;
    [SerializeField] protected float _speed;
    [SerializeField] private ParticleSystem _death;

    protected Vector3 _targetLastPosition;
    private Tweener _tween;

    private void Awake()
    {
        _player = GameObject.Find("Ship");
        _ship=_player.GetComponent<Ship>();        
    }

    private void Start()
    {
        
    }

    private void Update()
    {

    }
   
    protected Vector3 LookAtPlayer() 
    {
        Vector3 playerDir = _player.transform.position;
        Vector3 dir = playerDir - transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        return playerDir;
    }
  
    protected void InstantiateTween()
    {
        _tween = transform.DOMove(_targetLastPosition, 3.5f).SetAutoKill(false);
    }

    protected void Follow()
    {
        if (_targetLastPosition != _player.transform.position)
        {
            _tween.ChangeEndValue(_player.transform.position, true).Restart();
            _targetLastPosition = _player.transform.position;
        }
    }
    
    public static void Die() 
    {
        GameManager.Instance.SetScorePoint();
    }
}
