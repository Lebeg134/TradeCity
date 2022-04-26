using Lebeg134.Scripts.GUI.VisualUpdaters;
using UnityEngine;

public class VisualUpdater : MonoBehaviour, IVisualUpdateable
{
    public GameObject target;

    public void VisualUpdate()
    {
        target.GetComponent<IVisualUpdateable>().VisualUpdate();
    }
    void Start() { }
    void Update() { }


}
