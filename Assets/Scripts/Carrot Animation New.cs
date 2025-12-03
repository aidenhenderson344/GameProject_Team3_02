using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarrotAnimationNew : MonoBehaviour
{
    public float speed = 2f;
    public float height = 0.5f;

    private Vector3 startPosition;

    // Start is called before the first frame update
    private void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    private void Update()
    {
        float newY = startPosition.y + Mathf.Sin(Time.time * speed) * height;
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
        transform.Rotate(0f, 50f * Time.deltaTime, 0f, Space.Self);
    }
}
