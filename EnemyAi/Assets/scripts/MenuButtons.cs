using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
   public void StartGame()
   {
        SceneManager.LoadScene("Game");
   }
  public void ExitGame()
   {
        Application.Quit();
        Debug.Log("QUIT!");
   }
}
