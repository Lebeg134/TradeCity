using Assets.Scripts.GUI.VisualUpdaters;
using JHP4SD.Lebeg134.Module.Session;
using JHP4SD.Lebeg134.Module.Structures;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyLandsListScript : ListScript<Land>, IVisualUpdateable
{
    public void VisualUpdate()
    {
        Refresh();
    }

    protected override ICollection<Land> GetCollection()
    {
        return Player.CurrentPlayer.GetLands();
    }

    protected override void ProcessListItem(Land item, GameObject newListItem)
    {
        newListItem.GetComponent<OwnedlandVisualSript>().watched = item;
    }
}
