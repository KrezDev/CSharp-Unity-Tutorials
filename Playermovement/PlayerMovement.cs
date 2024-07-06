using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float Speed = 8f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    void Update()
    {
        MoveMent();
    }

    void MoveMent()
    {
        float x = Input.GetAxis("Horizontal") * Speed * Time.deltaTime;
        float y = Input.GetAxis("Jump") * Speed * Time.deltaTime;
        float z = Input.GetAxis("Vertical") * Speed * Time.deltaTime;

        transform.Translate(x, y, z);
    }
}
