using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public Transform player;          // Player
    public float followDistance = 6f; // Distância para começar a seguir
    public float speed = 3f;          // Velocidade do inimigo

    void Start()
    {
        // Caso você esqueça de arrastar no Inspector
        if (player == null)
            player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        if (player == null) return;

        float distance = Vector2.Distance(transform.position, player.position);

        if (distance <= followDistance)
        {
            FollowPlayer();
        }
    }

    void FollowPlayer()
    {
        Vector2 direction = (player.position - transform.position).normalized;
        transform.position += (Vector3)direction * speed * Time.deltaTime;
    }

    // Apenas para visualizar o raio no Editor
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, followDistance);
    }
}