using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseCollider : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D collision)
   {
      Debug.Log("Lose collider detected ball");
      SceneManager.LoadScene("Game Over");
   }
}
