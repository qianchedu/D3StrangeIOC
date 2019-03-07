

using strange.extensions.context.api;
using strange.extensions.context.impl;
using UnityEngine;

namespace TH.Demo001
{
    public class GameContext : MVCSContext
    {
        public GameContext() : base() { }
        public GameContext(MonoBehaviour view,bool autoStartup) : base(view, autoStartup) { }


        /// <summary>
        /// 绑定所有需要绑定的事件
        /// </summary>
        protected override void mapBindings()
        {
            //base.mapBindings();

            MapModel();
            MapView();
            MapController();


            commandBinder.Bind(ContextEvent.START).To<StartUpCommand>();


        }



        private void MapModel()
        {

        }

        private void MapView()
        {
            mediationBinder.Bind<UIMainPanelView>().To<UIMainPanelMediator>();
        }

        private void MapController()
        {
            commandBinder.Bind(NotificationCenter.ONCLICK_OPEN_UI_SETTINGPANEL).To<UISettingPanelOpenCommand>();
        }
    }

}
