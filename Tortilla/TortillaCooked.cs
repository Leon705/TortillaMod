using KitchenData;
using KitchenLib.Customs;
using UnityEngine;

namespace TortillaMod.Tortilla;

public class TortillaCooked : CustomItem
{
    public override string UniqueNameID => "Tortilla Cooked";
    public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("tortilla");

    public override void OnRegister(Item gameDataObject)
    { }
}