using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

/// <summary>
/// This class handles Main Menu UI part.
/// </summary>
namespace Outscal.BattleTank3D
{
    public class LobbyManager : MonoSingletonGeneric<UIManager>
    {
        [SerializeField] private string gameScene;

        public void OnPlayBtnClicked()
        {
            SceneManager.LoadScene(gameScene);
        }

        public void OnQuitBtnClicked()
        {
            Application.Quit();
        }
    }
}