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
        // Rotaci�n de la c�mara con el rat�n en todos los ejes
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        // Rotaci�n de la c�mara
        rotationX -= mouseY;
        rotationX = Mathf.Clamp(rotationX, -90, 90);
        rotationY += mouseX;

        transform.localRotation = Quaternion.Euler(rotationX, rotationY, 0);

        // Rotaci�n del personaje en el eje Y (izquierda-derecha)
        player.Rotate(Vector3.up * mouseX);

        // Ajusta la posici�n de la c�mara para que est� a la altura de los ojos del personaje
        transform.position = eyes.position;
    }
}
