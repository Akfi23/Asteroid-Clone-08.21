using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class Shooting : MonoBehaviour
{
    [SerializeField] private GameObject _bullet;
    [SerializeField] private int _bulletLifeTime;
    
    [SerializeField] private GameObject _laser;

    [SerializeField] private float _coolDown;
    [SerializeField] private static float _coolDownTimer=30;
    public static float CoolDownTimer 
    {
        get 
        {
            return _coolDownTimer;
        }
    }

    [SerializeField] public float _spellDuration;
   

    private void Start()
    {
        _laser.SetActive(false);        
    }

    private void Update()
    {
        if (_coolDownTimer > 0)
        {
            _coolDownTimer -= Time.deltaTime;
        }
        else if (_coolDown <= 0)
        {
            _coolDownTimer = 0;
        }


        if (_spellDuration <= 0)
        {
            StopCoroutine(GetUltimateSpell());
            _spellDuration = 0;
        }       
    }

    private void Shoot() 
    {
        GameObject newBullet= Instantiate(_bullet, transform.position, transform.rotation);
        Destroy(newBullet, _bulletLifeTime);
    }

    private IEnumerator GetUltimateSpell() 
    {
        while (_spellDuration>=0)
        {
            yield return null;
            _laser.SetActive(true);
            RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.up, 3f);
            Debug.DrawRay(transform.position, transform.up * 3, Color.red);

            if (hit)
            {
                Destroy(hit.collider.gameObject);
                Enemy.Die();
            }
            _spellDuration -= Time.deltaTime;
        }
        _laser.SetActive(false);
    }

    public void OnShoot(InputAction.CallbackContext context)
    {
        Shoot();
    }

    public void OnUltimate(InputAction.CallbackContext context)
    {
        if (_coolDownTimer == 0)
        {
            _spellDuration = 15;
            _coolDownTimer = 30;
            StartCoroutine(GetUltimateSpell());
        }     
    }    
}
