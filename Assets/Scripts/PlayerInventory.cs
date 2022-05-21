using UnityEngine;
using TMPro;

public class PlayerInventory : MonoBehaviour
{
    public TextMeshProUGUI coinText;

    int Coins = 0;

    void Start()
    {
        coinText.text = Coins.ToString();
    }

    public void AddCoin()
    {
        Coins++;
        coinText.text = Coins.ToString();
        //print($"Coins: {Coins}");
    }
}
