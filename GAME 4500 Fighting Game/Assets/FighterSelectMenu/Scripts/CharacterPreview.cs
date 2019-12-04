using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CharacterPreview : MonoBehaviour
{
    [SerializeField] private Image _characterPose;
    [SerializeField] private TextMeshProUGUI _characterName;

    public void UpdateCharacterPose(int index)
    {
        _characterPose.sprite = DataReferenceManager.Instance.characterPoses[index];
        _characterName.SetText(DataReferenceManager.Instance.characterNames[index]);
    }
}
