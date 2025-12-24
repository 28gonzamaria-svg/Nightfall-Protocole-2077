using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f; // Velocidad de movimiento
    public float mouseSensitivity = 2f; // Sensibilidad del mouse
    public Camera playerCamera;

    private float xRotation = 0f;

    void Update()
    {
        Move();
        Look();
    }

    void Move()
    {
        float x = Input.GetAxis("Horizontal"); // A/D o flechas
        float z = Input.GetAxis("Vertical");   // W/S o flechas

        Vector3 move = transform.right * x + transform.forward * z;
        transform.position += move * speed * Time.deltaTime;
    }

    void Look()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -80f, 80f); // Limita mirar arriba/abajo

        playerCamera.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        transform.Rotate(Vector3.up * mouseX);
    }
}