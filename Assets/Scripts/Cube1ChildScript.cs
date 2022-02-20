using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// DEMONSTRATION OF INHERITANCE
public class Cube1ChildScript : CubeBehaviour
{

    private float newRotationSpeedY = 35.0f;

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
    public override void CubeRotation()
    {
      transform.Rotate(rotationSpeedX, newRotationSpeedY * Time.deltaTime, rotationSpeedZ);
    }
}
