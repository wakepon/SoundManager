using UnityEngine;
using System.Collections;

public static class SoundExtentions
{
    public static SoundManager.Handle PlaySe(this MonoBehaviour behaviour, string name)
    {
        return SoundManager.Instance.PlaySe(name);
    }

    public static SoundManager.Handle PlaySe(this MonoBehaviour behaviour, string name, float delay)
    {
        return SoundManager.Instance.PlaySe(name,delay);
    }

    //Use this if you might want to stop while waiting for PlaySe.
    public static IEnumerator PlaySeProcess(this MonoBehaviour behaviour, string name, float delay)
    {
        yield return new WaitForSeconds(delay);
        SoundManager.Instance.PlaySe(name);
    }

    //@memo
    //it become also true when it is paused on first frame.
    //I can't find the solution.
    public static bool IsFinished(this AudioSource audio)
    {
        return audio.time == 0.0f && !audio.isPlaying;
    }
}
