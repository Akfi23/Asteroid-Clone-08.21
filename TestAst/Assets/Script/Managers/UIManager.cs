using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private static UIManager _UIInstance;
    public static UIManager UIInstance
    {
        get
        {
            if (_UIInstance == null)
            {
                Debug.Log("Manager is Null");
            }
            return _UIInstance;
        }
    }

    [SerializeField] private Text _scoreText;
    [SerializeField] private Text _FinalScoreText;
    [SerializeField] private Text _angleText;
    [SerializeField] private Text _cooldownText;
    [SerializeField] private Text _positionText;
    [SerializeField] private Text _countdownText;
    [SerializeField] private GameObject RestartButton;

    private void Awake()
    {
        _UIInstance = this;
    }
    void Start()
    {
        RestartButton.SetActive(false);
    }

    void Update()
    {
        _scoreText.text = "Score: " + GameManager.Instance.Score;
        _cooldownText.text = "CD Ulti: " + Shooting.CoolDownTimer;
        _angleText.text = "Angle: " + Ship.EulerAngZ;
        _positionText.text = "Pos: " + Ship.Position;

        if (GameManager.Instance.CountdownTime > 0)
        {
            _countdownText.text = "Untill action : " + GameManager.Instance.CountdownTime.ToString();
        }
        else 
        {
            _countdownText.gameObject.SetActive(false);
        }
    }

    public void OpenRestartHUD() 
    {
        RestartButton.SetActive(true);
        _FinalScoreText.text = "Total Score: " + GameManager.Instance.Score;
        Time.timeScale = 0;
    }
}
