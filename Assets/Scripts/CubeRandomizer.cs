using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRandomizer : CubeBehaviour
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

    //private void OnMouseDown()
    //{

    //}
}
