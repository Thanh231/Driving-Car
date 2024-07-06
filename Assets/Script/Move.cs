using UnityEngine;

public class Move : MonoBehaviour
{
    private float vertical;
    private float horizontal;
    public float speed;
    public float rotateSpeed;
    public bool alreadyOrder;

    void Update()
    {
        vertical = Input.GetAxis("Vertical") * Time.deltaTime * speed ;
        horizontal = Input.GetAxis("Horizontal") * Time.deltaTime * rotateSpeed;
        transform.Translate(0, vertical, 0);
        transform.Rotate(0, 0, -horizontal);
    }
}
