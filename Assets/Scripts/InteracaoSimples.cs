using UnityEngine;

public class InteracaoSimples : MonoBehaviour
{
    [SerializeField] private AudioClip sfxAlertSuccess;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("MaliciousUSB"))
        {
            return;
        }

        if (sfxAlertSuccess != null)
        {
            AudioSource.PlayClipAtPoint(sfxAlertSuccess, transform.position, 1f);
        }

        Destroy(other.gameObject);
    }
}
