using Lebeg134.Scripts.GUI.VisualUpdaters;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisualUpdater : MonoBehaviour, IVisualUpdateable
{
    public GameObject target;

    public void VisualUpdate()
    {
        target.GetComponent<IVisualUpdateable>().VisualUpdate();
    }
    void Start(){}
    void Update(){}


}
