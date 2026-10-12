using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    public int score = 10;
    private ScoreManager scoreManager;
    void Start()
    {
        scoreManager = FindFirstObjectByType<ScoreManager>();
    }
    
    private void OnTriggerEnter(Collider other)
    {
        scoreManager.AddScore(score);
        Destroy(gameObject);
    }
}
