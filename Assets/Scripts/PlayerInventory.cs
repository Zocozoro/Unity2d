using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    int Coins = 0;

    public void AddCoin()
    {
        Coins++;
        print($"Coins: {Coins}");
    }
}
