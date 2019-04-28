using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
      // Config parameters
   [SerializeField] Paddle  paddle;
   [SerializeField] Vector2 startingVelocity;

      // State
   private Vector2     offset;
   private Rigidbody2D m_rigidbody2d;
   private bool        m_hasStarted;

    // Start is called before the first frame update
    void Start()
    {
       m_hasStarted = false;
       m_rigidbody2d = GetComponent<Rigidbody2D>();
       m_rigidbody2d.simulated = false;
       offset = transform.position - paddle.transform.position;
       
    }

    // Update is called once per frame
    void Update()
    {
       if (!m_hasStarted) {
          LockBallToPaddle();
          LaunchOnMouseClick();
       }
    }

   private void LockBallToPaddle()
   {
      Vector2 paddlePos = new Vector2(
                paddle.transform.position.x,
                paddle.transform.position.y);

      transform.position = paddlePos + offset;
   }

   private void LaunchOnMouseClick()
    {
       if (Input.GetMouseButtonDown(0)) {
          m_hasStarted = true;
          m_rigidbody2d.simulated = true;
          m_rigidbody2d.velocity = startingVelocity;
       }
    }
}
