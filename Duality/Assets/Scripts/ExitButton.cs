using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButton : MonoBehaviour
{
  public void ExitGame(string scenename)
{
  Debug.Log("Exit button was pressed");
Application.Quit();
}
}
