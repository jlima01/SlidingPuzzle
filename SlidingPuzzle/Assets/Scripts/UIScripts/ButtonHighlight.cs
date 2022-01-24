using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonHighlight : MonoBehaviour, ISelectHandler , IPointerEnterHandler
{
  protected Button button;
  
  public UnityEvent OnHighlight, OnExitHighlight;

  void Start()
  {
    button = GetComponent<Button>();
  }

  public void OnPointerEnter(PointerEventData eventData)
  {
    if(button.interactable == true)
    {
      ActivateHLAction();
    }
  }
  
  public void OnSelect(BaseEventData eventData)
  {
  
  }
  public void ActivateHLAction()
  {
    if(OnHighlight != null)
      {
        OnHighlight.Invoke();
      }

      StartCoroutine(DeactivateAction());
  }
  public void DeactivateHLAction()
  {
    if(OnExitHighlight != null)
      {
        OnExitHighlight.Invoke();
      }
  }
  IEnumerator DeactivateAction()
  {
    yield return new WaitForSeconds(15);
    DeactivateHLAction();
  }
}