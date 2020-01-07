using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace AssemblyCSharp.Assets.Scripts
{
    public class PlayerCharacter : MonoBehaviour
    {
        private int _health;

        void Start()
        {
            _health = 5;
        }

        public void Hurt( int damage )
        {
            _health -= damage;
            Debug.Log( "Health: " + _health );
        }
    }
}
