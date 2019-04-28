using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
      // All values should be entered using the editor
   [SerializeField] float screenWidthUnits = -1.0f; // Bogus Value
   [SerializeField] float min = float.MaxValue;     // Bogus Value
   [SerializeField] float max = float.MinValue;     // Bogus Value

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
