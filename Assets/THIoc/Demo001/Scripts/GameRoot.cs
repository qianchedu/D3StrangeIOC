using strange.extensions.context.impl;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TH.Demo001
{
    public class GameRoot : ContextView
    {
        private void Awake()
        {
            context = new  GameContext(this,true);
            context.Start();

        }
    }

}
