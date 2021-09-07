using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

/// <summary>
/// This class handles UI part.
/// </summary>
namespace Outscal.BattleTank3D
{
    public class UIManager : MonoSingletonGeneric<UIManager>
    {
        public GameObject bulletAchivementPanel;
        public TextMeshProUGUI bulletAchiementText;
        [SerializeField] private string restartBtnScene;
        [SerializeField] private string mainMenuBtnScene;
        [SerializeField] private GameObject gameWinPanel;
        [SerializeField] private GameObject gameLosePanel;
        public static UIManager uiManagerInstance;
        public TextMeshProUGUI HealthText;
        public TextMeshProUGUI ScoreText;
        private int currentScore;

        private void Awake()
        {
            uiManagerInstance = this;
        }

        private void Start()
        {
            currentScore = 0;
            ScoreText.text = "Score:" + currentScore.ToString();
        }

        async public void PopUpAchievement(string achievement)
        {
            bulletAchivementPanel.SetActive(true);
            bulletAchiementText.text = "Achievement Unlocked : " + achievement;
            await new WaitForSeconds(3f);
            bulletAchivementPanel.SetActive(false);
        }

        public void OnRestartBtnClicked()
        {
            // SoundManager.Instance.PlayMusic(Sounds.buttonClick);
            SceneManager.LoadScene(restartBtnScene);
            gameWinPanel.SetActive(false);
            gameLosePanel.SetActive(false);
        }

        public void OnMainMenuBtnClicked()
        {
            // SoundManager.Instance.PlayMusic(Sounds.buttonClick);
            SceneManager.LoadScene(mainMenuBtnScene);
            gameWinPanel.SetActive(false);
            gameLosePanel.SetActive(false);
        }

        public void DisplayWinGamePanel()
        {
            gameWinPanel.SetActive(true);
        }

        public void DisplayLoseGamePanel()
        {
            gameLosePanel.SetActive(true);
        }

        public void UpdateScoreText(int scoreMultiplier = 1)
        {
            int finalScore = (currentScore + 10) * scoreMultiplier;
            currentScore = finalScore;
            ScoreText.text = "Score: " + finalScore.ToString();

        }


        public void UpdateHealthText(float currentHealth)
        {
            if (currentHealth < 0) currentHealth = 0;
            HealthText.text = "Health: " + currentHealth.ToString();
        }

        public void ResetScore()
        {
            currentScore = 0;
            ScoreText.text = "Score: " + currentScore.ToString();
        }

        // public int GetCurrentScore()
        // {
        //     return currentScore;
        // }
    }
}