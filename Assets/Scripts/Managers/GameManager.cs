using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    [Header("Pause Menu Stuff")]
    public GameObject pauseMenu;
    bool paused;

    public static GameManager instance;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        paused = false;
    }

    public void OnGamePause(InputAction.CallbackContext value)
    {
        if (value.started)
        {
            paused = !paused;
            if (paused) PauseGame();
            if (!paused) UnPauseGame(); 
        }
    }

    public void PauseGame()
    {
        PlayerController.instance.EnableMenuControl();
        Time.timeScale = 0;
        pauseMenu.SetActive(true);
    }

    public void UnPauseGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        PlayerController.instance.EnableCharacterControl();
    }

    public void QuitGame()
    {
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
