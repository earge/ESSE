using DynamicMVC.UI.DB;

namespace DynamicMVC.UI.Apps {
    using global::DynamicMVC.UI.DB;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public class AppBase_FisherManager : BaseApp, IApp{

        public AppBase_FisherManager() {
            this.system_name = "fishermanager";
            this.id = BaseApp.AppBase_23_FisherManager;
            this.name = "Fisher Manager";
            this.description = "Fish Farm Management";
            this.is_active = true;
            this.icon_id = app_icon.fa_fish.id;
        }

        public void Seed(DBContext db) {

        }
    }
}
