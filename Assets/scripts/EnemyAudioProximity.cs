using UnityEngine;

public class EnemyAudioProximity : MonoBehaviour
{
    public Transform player;          // Referência ao Player
    public float detectionRadius = 5f; // Distância para tocar o som

    private AudioSource audioSource;
    private bool isPlaying = false;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        float distance = Vector2.Distance(transform.position, player.position);

        if (distance <= detectionRadius && !isPlaying)
        {
            audioSource.Play();
            isPlaying = true;
        }
        else if (distance > detectionRadius && isPlaying)
        {
            audioSource.Stop();
            isPlaying = false;
        }
    }
}