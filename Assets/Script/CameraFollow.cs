using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform car;
    void Update()
    {
        transform.position = car.position + new Vector3(0,0,-10);
    }
}
