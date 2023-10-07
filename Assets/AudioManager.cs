using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip[] audioClips;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        PlayRandomAudio();
    }

    void PlayRandomAudio()
    {
        // Check if there are audio clips available
        if (audioClips.Length == 0)
        {
            Debug.LogError("No audio clips assigned!");
            return;
        }

        // Get a random audio clip from the array
        AudioClip randomClip = audioClips[Random.Range(0, audioClips.Length)];

        // Play the audio clip
        audioSource.clip = randomClip;
        audioSource.Play();

        // Invoke the method to play another random audio after a delay
        Invoke("PlayRandomAudio", randomClip.length + 5f);
    }
}
