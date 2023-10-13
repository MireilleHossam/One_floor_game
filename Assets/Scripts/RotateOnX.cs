using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateOnX : MonoBehaviour
{
    // Start is called before the first frame update
    float rotationSpeed = 20f;
    Vector3 newposition = new Vector3(1f, 0f, 0f);
    void Start()
    {
        Debug.Log(transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(transform.position, Vector3.right, rotationSpeed * Time.deltaTime);
    }
}
