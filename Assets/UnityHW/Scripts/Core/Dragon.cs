using UnityEngine;

namespace Assets.UnityHW.Scripts.Core
{
    internal class Dragon : Person
    {
        private void Start()
        {
            TakeDamage(20);    
        }

        public override void TakeDamage(int damageValue)
        {
            Debug.Log($"I, mighty dragon, have lost: {damageValue} hitpoints from a hunter's shot");
        }
    }
}
