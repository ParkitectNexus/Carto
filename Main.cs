using UnityEngine;

namespace Carto
{
    public class Main : IMod
    {
        private GameObject _go;
        
        public void onEnabled()
        {
            _go = new GameObject("Carto");

            _go.AddComponent<Carto>();
        }

        public void onDisabled()
        {
            Object.Destroy(_go);
        }

        public string Name { get { return "Carto"; } }
        public string Description { get { return "Gives every guests a map on arrival"; } }
    }
}
