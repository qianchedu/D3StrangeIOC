using strange.extensions.mediation.impl;

namespace TH.Demo001
{
    public class UIMainPanelMediator : EventMediator
    {
        [Inject]
        public UIMainPanelView View { get; set; }


        public override void OnRegister()
        {
            //base.OnRegister();
            View.dispatcher.AddListener(UIMainPanelView.ONCLICK_OPEN, OnClickOpenHandler);
            View.Init();
        }


        public override void OnRemove()
        {
            //base.OnRemove();

            View.dispatcher.RemoveListener(UIMainPanelView.ONCLICK_OPEN, OnClickOpenHandler);
        }


        private void OnClickOpenHandler()
        {
            dispatcher.Dispatch(NotificationCenter.ONCLICK_OPEN_UI_SETTINGPANEL);
        }



    }

}
