using System.Collections.Generic;
using Kitchen.TortillaMod;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.References;
using KitchenLib.Utils;
using UnityEngine;

namespace TortillaMod.Tortilla;

public class TortillaDish : CustomDish
{
    public override string UniqueNameID => "Tortilla";
    public override DishType Type => DishType.Base;
    public override UnlockGroup UnlockGroup => UnlockGroup.Dish;
    public override CardType CardType => CardType.Default;
    
    public override GameObject IconPrefab => Refs.Potato.Prefab;
    
    public override DishCustomerChange CustomerMultiplier => DishCustomerChange.None;
    public override Unlock.RewardLevel ExpReward => Unlock.RewardLevel.Medium;
    public override bool IsAvailableAsLobbyOption => true;
    public override bool RequiredNoDishItem => true;

    public override List<string> StartingNameSet => new List<string>
    {
        "Sandros Butze"
    };

    public override HashSet<Item> MinimumIngredients => new HashSet<Item>
    {
        Refs.Potato,
        Refs.Egg,
    };

    public override HashSet<Process> RequiredProcesses => new HashSet<Process>
    {
        Refs.RequireOven,
    };

    public override List<Dish.MenuItem> ResultingMenuItems => new List<Dish.MenuItem>()
    {
        new Dish.MenuItem() { Phase = MenuPhase.Main, Item = Refs.TortillaCooked, Weight = 1 },
    };

    public override Dictionary<Locale, string> Recipe => new Dictionary<Locale, string>
    {
        {
            Locale.German,
            "1. Chop potatoes.\n2. Add oil.\n3. Add egg.\n4Cook in oven.\n5 Serve."
        }
    };

    public override List<(Locale, UnlockInfo)> InfoList => new List<(Locale, UnlockInfo)>
    {
        { (Locale.German, LocalisationUtils.CreateUnlockInfo("Tortilla", "", "")) }
    };

    
    public override void OnRegister(Dish gdo)
    {
        gdo.Difficulty = 1;
    }
}