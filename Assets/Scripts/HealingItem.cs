using UnityEngine;

public class HealingItem : MonoBehaviour
{
    [Header("Healing Amount")]
    public float healAmount = 30f;

    private void OnTriggerEnter(Collider other)
    {
        PlayerHealth playerHealth =
            other.GetComponent<PlayerHealth>();

        if (playerHealth != null)
        {
            playerHealth.Heal(healAmount);

            // 拾取后销毁医疗包
            Destroy(gameObject);
        }
    }
}