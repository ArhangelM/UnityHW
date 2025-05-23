using UnityEngine;

namespace Assets.UnityHW.Scripts.Core
{
    internal class Player : Person
    {
        [SerializeField] private int _experience;
        public int Experience => _experience;

        private void Start()
        {
            TakeDamage(30);
        }

        public override void ShowStat()
        {
            base.ShowStat();
            Debug.Log($"Experience: {Experience}");
        }

        public override void TakeDamage(int damageValue)
        {
            Debug.Log($"My name is {Name}");
            Debug.Log($"After hitting with force: {damageValue}");
            Debug.Log($"I have: {Health -= damageValue}");
        }
    }
}
