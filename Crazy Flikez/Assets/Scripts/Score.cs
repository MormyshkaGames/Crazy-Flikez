using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public static Score instance;



    [SerializeField] private TextMeshProUGUI _currentScoreText;
    [SerializeField] private TextMeshProUGUI _highScoreText;
    [SerializeField] private TextMeshProUGUI _ShopPointsText;
    private int _score;
    public static int _points;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        _currentScoreText.text = _score.ToString();
       
        

        _highScoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        UpdateHighScore();

        
        _ShopPointsText.text = PlayerPrefs.GetInt("ShopPoints", 0).ToString();
        _points = PlayerPrefs.GetInt("ShopPoints");



    }

    private void UpdateHighScore()
    {
        if (_score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", _score);
            _highScoreText.text = _score.ToString();
        }
    }
    public void UpdateScore()
    {
        _score++;
        
        _currentScoreText.text = _score.ToString();
        UpdateHighScore();
        UpdateSHopPoints();
    }
    public void UpdateSHopPoints() {
        _points++;
        PlayerPrefs.SetInt("ShopPoints", _points);
        _ShopPointsText.text = _points.ToString();
        

    }
}
