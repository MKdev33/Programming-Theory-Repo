using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehaviour : MonoBehaviour
{

    private float rotationSpeedY = 10.0f;
    private float rotationSpeedX, rotationSpeedZ;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.green;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationSpeedX, rotationSpeedY * Time.deltaTime, rotationSpeedZ);
    }

}
