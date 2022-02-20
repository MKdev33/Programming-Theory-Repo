using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// DEMONSTRATION OF INHERITANCE
public class Cube2ChildScript : CubeBehaviour
{
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
      gameObject.GetComponent<Renderer>().material.color = Color.red;
    }
}
