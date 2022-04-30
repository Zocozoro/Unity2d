using UnityEngine;

public class CoinController : MonoBehaviour
{
    public GameObject reward;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Instantiate(reward, transform.position, Quaternion.identity);

            other.gameObject
                .GetComponent<PlayerInventory>()
                .AddCoin();

            Destroy(gameObject.transform.root.gameObject);
        }
    }
}
