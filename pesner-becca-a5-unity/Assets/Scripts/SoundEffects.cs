using UnityEngine;

public class SoundEffects : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializedField] private AudioSource _audioSource;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown)(0) == true)
        {
            GetComponent<_audioSource>().Play();
        }
    }
}
