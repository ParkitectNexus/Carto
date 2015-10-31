using System;
using Parkitect.UI;
using UnityEngine;

namespace Carto
{
    class Carto : MonoBehaviour
    {
        void Start()
        {
            EventManager.Instance.OnGuestEnteredPark += OnOnGuestEnteredPark;
        }

        private void OnOnGuestEnteredPark(Guest guest)
        {
            guest.addToInventory(new ParkMap());
        }
    }
}
