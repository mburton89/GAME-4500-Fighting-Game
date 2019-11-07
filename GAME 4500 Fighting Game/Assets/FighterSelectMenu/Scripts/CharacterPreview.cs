using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CharacterPreview : MonoBehaviour
{
    [SerializeField] private Image _characterPose;
    [SerializeField] private TextMeshProUGUI _characterName;

    //private void Start()
    //{
    //    _characterPose.sprite = DataReferenceManager.Instance.characterPoses[0];
    //    _characterName.SetText(DataReferenceManager.Instance.characterNames[0]);
    //}

    public void UpdateCharacterPose(int index)
    {
        _characterPose.sprite = DataReferenceManager.Instance.characterPoses[index];
        _characterName.SetText(DataReferenceManager.Instance.characterNames[index]);
    }
}
