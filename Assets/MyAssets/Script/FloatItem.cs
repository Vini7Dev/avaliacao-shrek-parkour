using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatItem : MonoBehaviour
{
    public float floatStrength = 1f;
    public float rotationSpeed = 10f;
    private float originalY;

    void Start()
    {
        originalY = transform.position.y;
    }

    void Update()
    {
        transform.position = new Vector3(
            transform.position.x,
            originalY + (Mathf.Sin(Time.time) * floatStrength),
            transform.position.z
        );

        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
