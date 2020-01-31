using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FurnitureButton : GazeableButton {

    public Object prefab;

    public override void OnPress(RaycastHit hitInfo)
    {
        base.OnPress(hitInfo);

        Player.instance.activeMode = InputMode.FURNITURE;

        Player.instance.activeFurniturePrefab = prefab;
        
    }
}
