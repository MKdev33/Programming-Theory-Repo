using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// DEMONSTRATION OF INHERITANCE
public class Cube3ChildScript : CubeBehaviour
{

    private float newRotationSpeedX = 10.0f;
    private float nullRotationSpeedY = 0.0f;
    private float newRotationSpeedZ = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
      SetColor();
    }

    // Update is called once per frame
    void Update()
    {
      CubeRotation();
    }

    // DEMONSTRATION OF POLYMORPHISM
    public override void SetColor()
    {
      gameObject.GetComponent<Renderer>().material.color = Color.blue;
    }

    public override void CubeRotation()
    {
      transform.Rotate(newRotationSpeedX * Time.deltaTime, nullRotationSpeedY, newRotationSpeedZ * Time.deltaTime);
    }
}
