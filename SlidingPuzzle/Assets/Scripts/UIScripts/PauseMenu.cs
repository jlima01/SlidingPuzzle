using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PauseMenu : MonoBehaviour
{
    public PlayerInput action;
    public static bool GameIsPaused = false;
    public bool pauseInput;
    public GameObject pauseHud;
    [SerializeField]
    protected PuzzleController puzzleController;
    private void Awake()
    {
        action = new PlayerInput();
        GameIsPaused = false;
        Time.timeScale = 1;
    }

    private void OnEnable()
    {
        action.Enable();
    }

    private void OnDisable()
    {
        action.Disable();
    }

    private void Start()
    {
        action.Gameplay.Pause.performed += _ => DeterminePause();
    }
    private void DeterminePause()
    {
        if(GameIsPaused)
        {
            Resume(pauseHud);
            puzzleController.puzzleManager.ChangeState(PuzzleManager.PuzzleState.MoveSelector);
        }   
        else 
        {
            puzzleController.puzzleManager.ChangeState(PuzzleManager.PuzzleState.Paused);
            Pause(pauseHud); 
        }         
    }
   public void Resume(GameObject pHud)
   {
        pHud.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
   }

   public void ResumeDead(GameObject pHud)
   {
        pHud.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;       
   }

   public void Pause(GameObject pMenuUI)
   {
        pMenuUI.SetActive(true);
        //Time.timeScale = 0f;
        GameIsPaused = true;  
   }
   public void WinHud()
   {
        //winHud.SetActive(true);
        //Time.timeScale = 0f;
        GameIsPaused = true;
   }

}
