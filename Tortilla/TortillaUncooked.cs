using System.Collections.Generic;
using Kitchen;
using Kitchen.TortillaMod;
using KitchenData;
using KitchenLib;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace TortillaMod.Tortilla;

public class TortillaUncooked : CustomItemGroup<TortillaUncooked.PotatoSoupPlainUncookedItemGroupView>
{
    public override string UniqueNameID => "Tortilla Uncooked";
    public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("tortilla");
    public override string ColourBlindTag => "TU";

    public override List<ItemGroup.ItemSet> Sets => new List<ItemGroup.ItemSet>()
    {
        new ItemGroup.ItemSet()
        {
            Max = 1,
            Min = 1,
            IsMandatory = true,
            Items = new List<Item>()
            {
                Refs.Potato,
            },
        },
        new ItemGroup.ItemSet()
        {
            Max = 1,
            Min = 1,
            IsMandatory = true,
            Items = new List<Item>()
            {
                Refs.Egg,
            },
        },
    };

    public override List<Item.ItemProcess> Processes => new List<Item.ItemProcess>
    {
        new Item.ItemProcess
        {
            Duration = 5f,
            IsBad = false,
            Process = Refs.CookProcess,
            Result = Refs.TortillaCooked,
        }
    };

    public override void OnRegister(ItemGroup gameDataObject)
    {
        if (Prefab.TryGetComponent<ItemGroupView>(out var itemGroupView))
        {
            itemGroupView.gameObject.transform.Find("Colour Blind").localPosition = new Vector3(0, 0.6f, 0);
        }

        Prefab.GetComponent<PotatoSoupPlainUncookedItemGroupView>()?.Setup(Prefab);
    }


    public class PotatoSoupPlainUncookedItemGroupView : ItemGroupView
    {
        internal void Setup(GameObject prefab)
        {
            ComponentGroups = new List<ComponentGroup>()
            {
                new ComponentGroup()
                {
                    Item = Refs.Potato,
                    DrawAll = true,
                },
                new ComponentGroup()
                {
                    Item = Refs.Egg,
                    DrawAll = true,
                },
            };
        }
    }
}