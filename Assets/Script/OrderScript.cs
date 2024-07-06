using UnityEngine;

public class OrderScript : MonoBehaviour
{
    public GameManager gm;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        bool ordered = collision.GetComponent<Move>().alreadyOrder;
        if (collision.tag == "Player" && !ordered)
        {
            gm.CallVisible("Was Order");
            collision.GetComponent<Move>().alreadyOrder = true;
        }
    }
}
