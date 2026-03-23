using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    public void PlayEtherealSound()
    {
        AudioManager.Instance.PlayClip(0);
    }

    public void StopEtherealSound()
    {
        AudioManager.Instance.StopClip(0);
    }
}
