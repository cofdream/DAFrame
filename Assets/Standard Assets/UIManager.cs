using UnityEngine;
using Cofdream.Utils;
using Cofdream.ExpandFunction;

namespace DA
{
    public class UIManager : Singleton<UIManager>
    {
        private UIManagerBind bind;
        protected override void SingletonInit()
        {
            
        }



        public override void Free()
        {

        }

        public void OpenWinow(string windowName)
        {
            GameObject window = LoadWindow(windowName);
        }

        public void CloseWindow(string windowName)
        {

        }

        private GameObject LoadWindow(string name)
        {
            return Resources.Load<GameObject>("Prefabs/UI/{0}/{0}".Format(name));
        }
    }
}