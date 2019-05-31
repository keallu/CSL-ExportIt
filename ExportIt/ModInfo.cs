using ICities;

namespace ExportIt
{
    public class ModInfo : IUserMod
    {
        public string Name => "Export It!";
        public string Description => "Allows to export meta data from the game.";

        public void OnSettingsUI(UIHelperBase helper)
        {
            UIHelperBase group;

            group = helper.AddGroup(Name);
            
            group = helper.AddGroup("Props");

            group.AddButton("Props", () =>
            {
                ExportUtils.ExportPropInfoToFile("Props", true, false);
            });

            group.AddButton("Props and buildings", () =>
            {
                ExportUtils.ExportPropsWithBuildingInfoToFile("PropsAndBuildings", true);
            });

            group.AddButton("Props and networks", () =>
            {
                ExportUtils.ExportPropsWithNetInfoToFile("PropsAndNetworks", true);
            });

            group = helper.AddGroup("Buildings");

            group.AddButton("Buildings and props", () =>
            {
                ExportUtils.ExportBuildingInfoWithPropsToFile("BuildingsAndProps", true, false);
            });

            group = helper.AddGroup("Network");

            group.AddButton("Networks and props", () =>
            {
                ExportUtils.ExportNetInfoWithLanePropsToFile("NetworksAndProps", true, false);
            });
        }
    }
}