using UnityEngine;

public class DestroyMe : MonoBehaviour
{
    public float aliveTime;

    void Start()
    {
        Destroy(gameObject, aliveTime);
    }
}
