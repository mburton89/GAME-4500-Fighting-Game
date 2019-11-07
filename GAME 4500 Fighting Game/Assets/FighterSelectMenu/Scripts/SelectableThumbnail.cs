using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SelectableThumbnail : MonoBehaviour
{
    private CharacterSelectMenu _characterSelectMenu;

    [SerializeField] private Image _characterThumbnail;
    [SerializeField] private Button _button;

    private int _characterIndex;

    public void Init(CharacterSelectMenu characterSelectMenu, int characterIndex)
    {
        _characterSelectMenu = characterSelectMenu;
        _characterIndex =  characterIndex;
        _characterThumbnail.sprite = DataReferenceManager.Instance.characterThumbnails[characterIndex];
    }

    private void OnEnable()
    {
        _button.onClick.AddListener(UpdateCharacterPreview);
    }

    void UpdateCharacterPreview()
    {
        FighterSelectSceneController.Instance.UpdatePlayer1Preview(_characterIndex);
    }

    public void Select()
    {
        _button.Select();
        FighterSelectSceneController.Instance.UpdatePlayer1Preview(_characterIndex);
    }
}
