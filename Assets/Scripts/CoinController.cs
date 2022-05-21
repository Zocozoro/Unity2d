using UnityEngine;

public class CoinController : MonoBehaviour
{
    public GameObject reward;

    bool collected = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (!collected && other.CompareTag("Player"))
        {
            collected = true;
            Instantiate(reward, transform.position, Quaternion.identity);
            other.gameObject
                .GetComponent<PlayerInventory>()
                .AddCoin();
            Destroy(gameObject.transform.root.gameObject);
        }
    }
}
