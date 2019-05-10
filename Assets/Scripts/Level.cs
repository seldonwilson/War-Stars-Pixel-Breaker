using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
      // Configuration Parameters
   [SerializeField] int breakableBlocks; // Serialized for debugging purposes

      // Cached reference
   SceneLoader sceneLoader;

   private void Start()
   {
      sceneLoader = FindObjectOfType<SceneLoader>();
   }

   public void CountBreakableBlocks()
   {
      breakableBlocks++;
   }

   public void BlockDestroyed()
   {
      breakableBlocks -= 10;

      if (breakableBlocks <= 0) {
         sceneLoader.LoadNextScene();
      }
   }
}
