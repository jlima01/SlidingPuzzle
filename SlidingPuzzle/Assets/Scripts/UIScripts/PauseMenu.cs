using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PauseMenu : MonoBehaviour
{
    public PlayerInput action;
    public static bool GameIsPaused, GameIsFinished = false;
    bool pauseInput, isOnPieceSelection;
    public GameObject pauseHud, winHud;

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

        PauseMenu.GameIsFinished = false;
        PauseMenu.GameIsPaused = false;
    }
    void Update()
    {
        if(GameIsFinished)
        {
            GameWin();
        }
    }
    private void DeterminePause()
    {
        if(GameIsPaused)
        {
            Resume(pauseHud);

            if(isOnPieceSelection)
            puzzleController.puzzleManager.ChangeState(PuzzleManager.PuzzleState.PuzzleSelected);
            else
            puzzleController.puzzleManager.ChangeState(PuzzleManager.PuzzleState.MoveSelector);   
        }   
        else 
        {
            if(puzzleController.puzzleManager.GetState() == PuzzleManager.PuzzleState.MoveSelector)
            {
                isOnPieceSelection = false;  
            }

            if(puzzleController.puzzleManager.GetState() == PuzzleManager.PuzzleState.PuzzleSelected)
            {
                isOnPieceSelection = true;    
            }
            
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
   public void GameWin()
   {
        winHud.SetActive(true);
        //Time.timeScale = 0f;
        GameIsPaused = true;
   }

}
