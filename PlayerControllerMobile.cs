using UnityEngine;
using UnityEngine.UI;

public class PlayerControllerMobile : MonoBehaviour
{
    public float speed = 5f;
    public float lookSpeed = 2f;
    public Camera playerCamera;

    public Joystick moveJoystick; // Joystick para mover
    public Joystick lookJoystick; // Joystick para mirar

    private float xRotation = 0f;

    void Update()
    {
        Move();
        Look();
    }

    void Move()
    {
        float x = moveJoystick.Horizontal;
        float z = moveJoystick.Vertical;

        Vector3 move = transform.right * x + transform.forward * z;
        transform.position += move * speed * Time.deltaTime;
    }

    void Look()
    {
        float mouseX = lookJoystick.Horizontal * lookSpeed;
        float mouseY = lookJoystick.Vertical * lookSpeed;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -80f, 80f);

        playerCamera.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        transform.Rotate(Vector3.up * mouseX);
    }
}