using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    [Header("HUD Stuff")]
    public GameObject HUD;

    [Header("Pause Menu Stuff")]
    public GameObject pauseMenu;
    bool paused;


    [Header("Other Stuff")]
    public AudioManager audioManager;
    public bool simulateNewGame;

    public enum GameStates
    {
        startScreen,
        gameplayScreen,
    }

    public GameStates gameState;


    public static GameManager instance;

    private void Awake()
    {
        instance = this;
        if (simulateNewGame) gameState = GameStates.startScreen;
        else gameState = GameStates.gameplayScreen;
    }

    private void Start()
    {
        if (simulateNewGame) InitializeGame();
        else ContinueGame();
    }

    public void InitializeGame()
    {
        CameraManager.instance.heartRoomCam.SetActive(true);
        PlayerController.instance.gameObject.GetComponent<Movement>().enabled = false;
        PlayerController.instance.EnableMenuControl();
    }

    public void ContinueGame()
    {
        CameraManager.instance.heartRoomCam.SetActive(false);
        CameraManager.instance.playerOrbitCam.SetActive(true);
        PlayerController.instance.gameObject.GetComponent<Movement>().enabled = true;
        PlayerController.instance.EnableCharacterControl();
        gameState = GameStates.gameplayScreen;
        HUD.SetActive(true);
    }

    public void OnGamePause(InputAction.CallbackContext value)
    {
        if (value.started)
        {
            switch (gameState)
            {
                case GameStates.startScreen:
                    {
                        ContinueGame();
                    }
                    break;
                case GameStates.gameplayScreen:
                    {
                        if (!paused) PauseGame();
                        if (paused) UnPauseGame();
                        paused = !paused;
                    }
                    break;
            }
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

    public void DirectUnPause()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        PlayerController.instance.EnableCharacterControl();
        paused = false;
    }

    public void QuitGame()
    {
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
