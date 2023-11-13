using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{
    public Transform player;
    public float mouseSensitivity = 2.0f;
    public Transform eyes;

    private float rotationX = 0;
    private float rotationY = 0;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        // Rotación de la cámara con el ratón en todos los ejes
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        // Rotación de la cámara
        rotationX -= mouseY;
        rotationX = Mathf.Clamp(rotationX, -90, 90);
        rotationY += mouseX;

        transform.localRotation = Quaternion.Euler(rotationX, rotationY, 0);

        // Rotación del personaje en el eje Y (izquierda-derecha)
        player.Rotate(Vector3.up * mouseX);

        // Ajusta la posición de la cámara para que esté a la altura de los ojos del personaje
        transform.position = eyes.position;
    }
}
