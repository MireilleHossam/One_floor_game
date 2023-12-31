using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingOnY : MonoBehaviour
{
    float rotationSpeed = 20f;
    Vector3 newPosition = new Vector3(0f, 1f, 0f);

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(transform.position, Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
