using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform Player;
    public float MouseSpeed = 2f;

    private float vR = 0;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        vR = transform.localEulerAngles.x;
    }

    void Update()
    {
        CameraFps();
    }

    void CameraFps()
    {
        float mouseX = Input.GetAxis("Mouse X") * MouseSpeed;
        float mouseY = -Input.GetAxis("Mouse Y") * MouseSpeed;

        Player.Rotate(Vector3.up * mouseX);

        vR += mouseY;
        vR = Mathf.Clamp(vR,-90f,90f);

        transform.localRotation = Quaternion.Euler(vR,0,0);
    }
}
