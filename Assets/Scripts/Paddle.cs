using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
   [SerializeField] float screenWidthUnits = -1.0f;
   [SerializeField] float min = float.MaxValue;
   [SerializeField] float max = float.MinValue;

    // Start is called before the first frame update
    void Start()
    {
      float width = gameObject.GetComponent<Collider2D>().bounds.size.x;
      min = width / 2.0f;
      max = screenWidthUnits - width / 2.0f;
    }

    // Update is called once per frame
    void Update()
    {
       float mouseXPosUnits = Input.mousePosition.x / Screen.width * screenWidthUnits;
       Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y);
       paddlePos.x = Mathf.Clamp(mouseXPosUnits, min, max);
       transform.position = paddlePos;

    }
}
