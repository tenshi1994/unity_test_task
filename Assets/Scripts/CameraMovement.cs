using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] float rotateSpeed = 1f;

    [SerializeField] Transform target;
    [SerializeField] Transform player;
    float mouseX, mouseY;

    void Start()
    {
        
    }

    void Update()
    {
        mouseX += Input.GetAxis("Mouse X") * rotateSpeed;
        mouseY -= Input.GetAxis("Mouse Y") * rotateSpeed;

        target.rotation = Quaternion.Euler(mouseY, mouseX, 0);
    }
}
