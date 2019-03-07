using strange.extensions.command.impl;
using strange.extensions.context.api;
using UnityEngine;

namespace TH.Demo001
{
    public class StartUpCommand : EventCommand
    {

        [Inject(ContextKeys.CONTEXT_VIEW)]
        public GameObject ContextView { get; set; }

        public override void Execute()
        {
            //base.Execute();
            Transform canvas = ContextView.transform.Find("Canvas");
            GameObject clone = Resources.Load("Demo001/Prefabs/UIMainPanel", typeof(GameObject)) as GameObject;
            GameObject uiMain = GameObject.Instantiate(clone) as GameObject;
            uiMain.transform.SetParent(canvas, false);

        }
    }
}

