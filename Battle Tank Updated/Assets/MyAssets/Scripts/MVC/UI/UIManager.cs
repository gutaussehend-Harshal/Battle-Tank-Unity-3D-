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

        private void Awake()
        {
            uiManagerInstance = this;
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
            SceneManager.LoadScene(restartBtnScene);
            gameWinPanel.SetActive(false);
            gameLosePanel.SetActive(false);
        }
        
        public void OnMainMenuBtnClicked()
        {
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
    }
}