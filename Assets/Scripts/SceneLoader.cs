using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
   public void LoadNextScene()    
   {
      int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
      int maxSceneIndex = SceneManager.sceneCountInBuildSettings;
      SceneManager.LoadScene((currentSceneIndex + 1) % maxSceneIndex);
   }

   public void Quit()
   {
      Application.Quit();
   }
}
