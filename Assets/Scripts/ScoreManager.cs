using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : Singleton<ScoreManager>
{
    public int score = 0;
    public Text scoreText;

    private void Update()
    {
        scoreText.text = "Number of Chickens: " + score;
    }

}
