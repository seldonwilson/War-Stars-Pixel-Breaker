using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
   [SerializeField] float screenWidthUnits = -1.0f;
   [SerializeField] float min = float.MinValue;
   [SerializeField] float max = float.MaxValue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       float mouseXPosUnits = Input.mousePosition.x / Screen.width * screenWidthUnits;
      Debug.Log(mouseXPosUnits);
       Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y);
       paddlePos.x = Mathf.Clamp(mouseXPosUnits, min, max);
       transform.position = paddlePos;
    }
}
