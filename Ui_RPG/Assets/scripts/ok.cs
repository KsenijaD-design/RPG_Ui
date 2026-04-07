using UnityEngine;

public class ok : MonoBehaviour
{
    [Header("Music")]
    public AudioSource CojTrack;
    public AudioSource ClassicmoodTrack;
    [Header("Mood Settings")]
    public bool isSilentMode = true;
    public float moodLevel;
    void Start()
    {
        Debug.Log("Hi");
        if (isSilentMode)
        {
            Debug.Log("Silent!!! Children, calm down!!!");
        }
        else
        {
            Debug.Log("Chaos allowed, but not with children");
        }
        Music();
    }
    public void Music()
    {
        if (moodLevel < 0.5 && isSilentMode)
        {
            Debug.Log("Music?");
            ClassicmoodTrack.Play();
            Debug.Log("All wil be ok. Children! Calm down!");
        }
        else if (moodLevel > 0.5)
        {
           Debug.Log("Ok, it is good time for" + CojTrack.clip.name);
           CojTrack.Play();
           Debug.Log("All wil be ok. Oh, the kids are finally gone...");
        }
    }
}
