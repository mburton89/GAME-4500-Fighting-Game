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

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
}
