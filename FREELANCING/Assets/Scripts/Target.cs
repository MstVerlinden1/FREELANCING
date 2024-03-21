using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 50;
    public delegate void TargetScore();
    public static event TargetScore ApplyScore;
    /// <summary>
    /// takes the amount(float) and removes that amout from the heath
    /// </summary>
    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            if (ApplyScore != null)
            {
                ApplyScore();
            }
            Die();
        }
    }
    private void Die()
    {
        Destroy(gameObject);
    }

}
