using Lebeg134.Module.Structures;
using UnityEngine;
using UnityEngine.UI;

public class OwnedlandVisualSript : MonoBehaviour
{
    public Land watched;
    public Image sprite;
    public Text nameText;
    public GameObject produceDisplay;

    void Start()
    {
        nameText.text = watched.GetName();
        produceDisplay.GetComponent<ResourceDisplayScript>().Watched = watched.GetProduce()[0]; //TODO if produces more than one!

        var loadedSprite = Resources.Load<Sprite>(watched.GetResourcepath());
        if (loadedSprite != null)
            sprite.sprite = loadedSprite;
    }
    void Update()
    {

    }
}
