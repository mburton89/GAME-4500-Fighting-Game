using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataReferenceManager : MonoBehaviour
{
    public static DataReferenceManager Instance;

    public List<string> characterNames;
    public List<Sprite> characterThumbnails;
    public List<Sprite> characterPoses;
    public List<Sprite> levelImages;

    public List<List<Sprite>> idleSprites;
    [SerializeField] private List<Sprite> alecIdle;
    [SerializeField] private List<Sprite> danielIdle;
    [SerializeField] private List<Sprite> dannyIdle;
    [SerializeField] private List<Sprite> evanIdle;
    [SerializeField] private List<Sprite> joshIdle;
    [SerializeField] private List<Sprite> markIdle;
    [SerializeField] private List<Sprite> robertIdle;
    [SerializeField] private List<Sprite> zachIdle;
    [SerializeField] private List<Sprite> mattIdle;

    public List<AudioClip> characterConfirmVO;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }

        idleSprites = new List<List<Sprite>>();

        idleSprites.Add(alecIdle);
        idleSprites.Add(danielIdle);
        idleSprites.Add(dannyIdle);
        idleSprites.Add(evanIdle);
        idleSprites.Add(joshIdle);
        idleSprites.Add(markIdle);
        idleSprites.Add(robertIdle);
        idleSprites.Add(zachIdle);
        idleSprites.Add(mattIdle);
    }
}
