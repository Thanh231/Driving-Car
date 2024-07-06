using UnityEngine;

public class DeliveryScript : MonoBehaviour
{
    public GameManager gm;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        bool ordered = collision.GetComponent<Move>().alreadyOrder;
        if (collision.tag == "Player" && ordered)
        {
            gm.CallVisible("Was Delivered");
            collision.GetComponent<Move>().alreadyOrder = false;
        }
    }
}
