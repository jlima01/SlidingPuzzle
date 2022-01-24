using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputHandler : MonoBehaviour
{
	public Vector2 MovementInput {get; private set;}
	public Vector2 MousePosition {get; private set;} 
	public bool InteractInput {get; private set;} 
	public bool PauseInput {get; private set;} 
	public static bool s_pauseInput;
	public void OnMoveInput(InputAction.CallbackContext context)
	{
		MovementInput = context.ReadValue<Vector2>();
	}  
	public void OnMousePositionInput(InputAction.CallbackContext context)
	{
		MousePosition = context.ReadValue<Vector2>();
	}
	public void OnInteractInput(InputAction.CallbackContext context)
	{
		if(context.started)
		{
			InteractInput = true;
		}	
		if(context.canceled)
		{
			InteractInput = false;
		}
	} 
	public void OnPauseInput(InputAction.CallbackContext context)
    {
        if(context.started)
        {
			PauseInput = true;
			s_pauseInput = PauseInput;
        }	

		if(context.canceled)
		{
			PauseInput = false;
			s_pauseInput = PauseInput;
		}
    }
	public void UsePauseInput() => PauseInput = false;
}
