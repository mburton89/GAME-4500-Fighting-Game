using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelectMenu : MonoBehaviour
{
    [SerializeField] private SelectableThumbnail _selectableThumbnailPrefab;
    [SerializeField] private GridLayoutGroup _grid;

    private List<SelectableThumbnail> _allThumbnails = new List<SelectableThumbnail>();

    void Start()
    {
        for (int i = 0; i < DataReferenceManager.Instance.characterNames.Count; i++)
        {
            SelectableThumbnail newThumbnail = Instantiate(_selectableThumbnailPrefab);
            newThumbnail.transform.SetParent(_grid.transform);
            newThumbnail.Init(this, i);
            newThumbnail.transform.localScale = Vector3.one;
            _allThumbnails.Add(newThumbnail);

        }

        _allThumbnails[0].Select();
    }
}
