using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStatus : MonoBehaviour
{
   [Range(0.1f, 10.0f)] [SerializeField] float gameSpeed;

    // Start is called before the first frame update
    void Start()
    {
        gameSpeed = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = gameSpeed;
    }
}
