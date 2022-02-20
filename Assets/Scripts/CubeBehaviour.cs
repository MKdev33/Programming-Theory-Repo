using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehaviour : MonoBehaviour
{

    //DEMONSTRATION OF ENCAPSULATION
    public static float rotationSpeedY = 10.0f;
    public static float rotationSpeedX { get; }
    public static float rotationSpeedZ { get; }

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

    // DEMONSTRATION OF ABSTRACTION
    public virtual void SetColor()
    {
      gameObject.GetComponent<Renderer>().material.color = Color.green;
    }

    public virtual void CubeRotation()
    {
      transform.Rotate(rotationSpeedX, rotationSpeedY * Time.deltaTime, rotationSpeedZ);
    }

}
