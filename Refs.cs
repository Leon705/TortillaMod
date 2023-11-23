using KitchenData;
using KitchenLib.References;
using KitchenLib.Utils;
using TortillaMod.Tortilla;

namespace Kitchen.TortillaMod;

public class Refs
{
    public static Item Potato => (Item)GDOUtils.GetExistingGDO(ItemReferences.Potato);
    public static Item Milk => (Item)GDOUtils.GetExistingGDO(ItemReferences.Milk);
    public static Item Egg => (Item)GDOUtils.GetExistingGDO(ItemReferences.Egg);
    
    public static Item TortillaCooked => GDOUtils.GetCastedGDO<Item, TortillaCooked>();

    
    public static Process CookProcess => (Process) GDOUtils.GetExistingGDO(ProcessReferences.Cook);
    public static Process ChopProcess => (Process) GDOUtils.GetExistingGDO(ProcessReferences.Chop);
    public static Process RequireOven => (Process) GDOUtils.GetExistingGDO(ProcessReferences.RequireOven);
}