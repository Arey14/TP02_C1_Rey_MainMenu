using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5f;
    private SpriteRenderer sr;
    [SerializeField] private KeyCode KeyCodeUp = KeyCode.W;
    [SerializeField] private KeyCode KeyCodeDown = KeyCode.S;
    [SerializeField] private KeyCode KeyCodeLeft = KeyCode.A;
    [SerializeField] private KeyCode KeyCodeRight = KeyCode.D;
    [SerializeField] private KeyCode KeyCodeRotateLeft = KeyCode.Q;
    [SerializeField] private KeyCode KeyCodeRotateRight = KeyCode.E;
    [SerializeField] private KeyCode KeyCodeChangeColor = KeyCode.R;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        float step = speed * Time.deltaTime;

        float rotationangle = 10.0f;

        // Logica movimiento

        if (Input.GetKey(KeyCodeUp))
        {
            transform.Translate(Vector2.up * step);
        }
        if (Input.GetKey(KeyCodeDown))
        {
            transform.Translate(Vector2.down * step);
        }
        if (Input.GetKey(KeyCodeLeft))
        {
            transform.Translate(Vector2.left * step);
        }
        if (Input.GetKey(KeyCodeRight))
        {
            transform.Translate(Vector2.right * step);
        }
    
        // Logica giritos
        if (Input.GetKeyDown(KeyCodeRotateLeft))
        {
            transform.Rotate(0.0f, 0.0f, rotationangle, Space.Self);
        }

        if (Input.GetKeyDown(KeyCodeRotateRight))
        {
            transform.Rotate(0.0f, 0.0f, -rotationangle, Space.Self);
        }
        // Logica colorcitos
        if (Input.GetKeyUp(KeyCodeChangeColor))
        {
            sr.color = new Color(Random.value, Random.value, Random.value);
        }
    }
}
