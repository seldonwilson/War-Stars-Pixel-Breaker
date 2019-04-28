using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
      // Config parameters
   [SerializeField] Paddle paddle = null;

      // State
   Vector2 offset;

    // Start is called before the first frame update
    void Start()
    {
       offset = transform.position - paddle.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
       Vector2 paddlePos = new Vector2(
          paddle.transform.position.x, 
          paddle.transform.position.y);

       transform.position = paddlePos + offset;
    }
}
