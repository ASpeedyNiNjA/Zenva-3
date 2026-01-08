using UnityEngine;

public class Coin : MonoBehaviour
{
    public int scoreToGive;

    //My Code
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<PlayerController>().AddScore(1);
            Destroy(this.gameObject);
        }
    }
}
