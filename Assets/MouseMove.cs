using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMove : MonoBehaviour
{
    public float speed = 10.0f;
    Vector3 position;

    void Start()
    {
        position = transform.position;
    }

    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.x = Mathf.Clamp01(mousePosition.x / (float)Screen.width) - 0.5f;
        mousePosition.y = Mathf.Clamp01(mousePosition.y / (float)Screen.height) - 0.5f;

        position.x = Mathf.Clamp(position.x + Input.GetAxis("Horizontal") * Time.deltaTime * speed, -3.0f, 3.0f);
        position.y = Mathf.Clamp(position.y + Input.GetAxis("Vertical") * Time.deltaTime * speed, 3.0f, 6.0f);

        transform.rotation = Quaternion.Euler(mousePosition.y * -45.0f, mousePosition.x * 45.0f, 0.0f);
        transform.position = position;
    }
}
