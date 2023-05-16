using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    public Camera cam;
    private float xRotate = 0f;

    public float xSense = 25f;
    public float ySense = 25f;

    public void ProcessLook(Vector2 input)
    {
        float mouseX = input.x;
        float mouseY = input.y;

        xRotate -= (mouseY * Time.deltaTime) * ySense;
        xRotate = Mathf.Clamp(xRotate, -80f, 80f);
        cam.transform.localRotation = Quaternion.Euler(xRotate, 0, 0);
        transform.Rotate(Vector3.up * (mouseX * Time.deltaTime) * xSense);
    }
}
