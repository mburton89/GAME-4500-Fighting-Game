using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FighterSelectSceneController : MonoBehaviour
{
    public static FighterSelectSceneController Instance;

    [SerializeField] private CharacterPreview _player1Preview;
    [SerializeField] private CharacterPreview _player2Preview;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    public void UpdatePlayer1Preview(int index)
    {
        _player1Preview.UpdateCharacterPose(index);
    }
}
