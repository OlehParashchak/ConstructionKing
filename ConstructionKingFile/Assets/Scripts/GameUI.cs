using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUI : MonoBehaviour
{
    public TextMeshProUGUI bestScoreText;

    private void Start()
    {
        bestScoreText.text = PlayerPrefs.GetInt("BestScore").ToString();
    }

    public void RestartButtton()
    {
        SceneManager.LoadScene(0);
    }
}
