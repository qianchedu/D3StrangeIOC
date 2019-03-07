using strange.extensions.command.impl;
using strange.extensions.context.api;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TH.Demo001
{
    public class UISettingPanelOpenCommand : EventCommand
    {
        [Inject(ContextKeys.CONTEXT_VIEW)]
        public GameObject ContextVie { get; set; }

        public override void Execute()
        {
            Transform canvas = ContextVie.transform.Find("Canvas");
            Transform uiSettingClone = canvas.Find("UISettingPanel(Clone)");

            if(uiSettingClone != null)
            {
                return;
            }

            GameObject clone = Resources.Load("Demo001/Prefabs/UISettingPanel", typeof(GameObject)) as GameObject;
            GameObject uiSetting = GameObject.Instantiate(clone) as GameObject;
            uiSetting.transform.SetParent(canvas, false);
        }

    }

}
