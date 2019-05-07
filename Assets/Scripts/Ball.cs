using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
      // Config parameters
   [SerializeField] Paddle      paddle       = null;
   [SerializeField] Vector2     initVelocity = new Vector2();
   [SerializeField] AudioClip[] ballSounds   = null;

      // State
   private Vector2     offset;
   private Rigidbody2D m_rigidbody2d;
   private bool        m_hasStarted;

      // Cached component referencesprivate
   private AudioSource myAudioSource;

    // Start is called before the first frame update
    void Start()
    {
       m_hasStarted = false;
       m_rigidbody2d = GetComponent<Rigidbody2D>();
       m_rigidbody2d.simulated = false;
       offset = transform.position - paddle.transform.position;
       myAudioSource = GetComponent<AudioSource>();
       
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
          m_rigidbody2d.velocity = initVelocity;
       }
    }

   private void OnCollisionEnter2D(Collision2D collision)
   {
      if (m_hasStarted) {
         AudioClip clip = ballSounds[Random.Range(0, ballSounds.Length)];
         myAudioSource.PlayOneShot(clip);
      }
   }
}
