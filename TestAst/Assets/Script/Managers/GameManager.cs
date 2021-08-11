using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    private static ParticleSystem _death;
    [SerializeField] private ParticleSystem _deathEffect;

    public int Score { get; private set; }
    public int LastScore { get; private set; }

    public int CountdownTime { get; private set; }
    public static GameManager Instance 
    {
        get 
        {
            if (_instance == null) 
            {
                Debug.Log("Manager is Null");
            }
            return _instance;
        }
    }

    private void Awake()
    {
        _instance = this;
        _death = _deathEffect;
    }

    private void Start()
    {
        Time.timeScale = 1;
        CountdownTime = 3;
        StartCoroutine(PlayCountdownTimer());
    }

    private void Update()
    {

    }

    public void SetScorePoint() 
    {
        Score += 1;
    }

    public static void PlayDeathEffect(Vector3 position) 
    {
        ParticleSystem newEffect= Instantiate(_death, position, Quaternion.identity);
        Destroy(newEffect.gameObject, 1);
    }
    private IEnumerator PlayCountdownTimer()
    {
        while (CountdownTime > 0)
        {
            yield return new WaitForSeconds(1f);
            CountdownTime--;
        }

        yield return new WaitForSeconds(1f);
    }

    public static void Restart() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); 
    }
}
