using strange.extensions.dispatcher.eventdispatcher.api;
using strange.extensions.mediation.impl;
using UnityEngine;
using UnityEngine.UI;

namespace TH.Demo001
{
    public class UIMainPanelView : View
    {

        public const string ONCLICK_OPEN = "OPEN";
        [Inject]
        public IEventDispatcher dispatcher { get; set; }


        private Button btnOpen;

        public void Init()
        {
            Debug.Log(this.gameObject + "==" + this.gameObject.transform + "dispatcher:" + dispatcher);
            btnOpen = this.gameObject.transform.Find("BottonPanel/BtnOpen").GetComponent<Button>();
            btnOpen.onClick.AddListener(OnClickOpenHandler);
        }


        private void OnClickOpenHandler()
        {
            dispatcher.Dispatch(ONCLICK_OPEN);
        }


    }

}
