using UnityEngine.UI;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] private Text txtScore;
    
    public int Score
    {
        get { return score; }
        set
        {
            txtScore.text = value.ToString();
            score = value;
        }
    }

    private int score;

    void Start()
    {
        txtScore.text = "0";
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Food"))
            return;
        Alimento food = collision.gameObject.GetComponent<Alimento>();
        Score += food.saturation;
        Destroy(food.gameObject);
    }
}
