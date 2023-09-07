using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
   public void StartGame()
   {
        SceneManager.LoadScene("Level_1");
   }
  public void ExitGame()
   {
        Application.Quit();
        Debug.Log("QUIT!");
   }
}
