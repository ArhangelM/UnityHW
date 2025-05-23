using UnityEngine;

namespace Assets.UnityHW.Scripts.Core
{
    public abstract class Person : MonoBehaviour
    {
        [SerializeField] private string _name;
        [SerializeField] private int _health;

        public string Name
        {
            get => _name;
        }

        public int Health
        {
            get => _health;
            set
            {
                if (value < 0 || value > 100)
                    Debug.LogWarning("value < 0 || value > 100");
                else
                    _health = value;
            }
        }

        public virtual void ShowStat()
        {
            Debug.Log($"name: {Name}");
        }

        public abstract void TakeDamage(int damageValue);
    }
}