using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APR_jahresprojekt_podoprygora
{
    internal class game1
    {
        private int _speed;
        private int _jumpheight;
        private int _health;
        private int _damage;
        private int _heal;

        private Enum _forward;
        private Enum _backward;
        private Enum _jump;
        

        public int speed
        {
            get { return _speed; }
            set { _speed = value; }
        }
        public int jumpheight
        {
            get { return _jumpheight; }
            set { _jumpheight = value; }
        }
        public int health
        {
            get { return _health; }
            set { _health = value; }
        }
        public int damage
        {
            get { return _damage; }
            set { _damage = value; }
        }
        public int heal
        {
            get { return _heal; }
            set { _heal = value; }
        }
       
        public Enum forward
        {
            get { return _forward; }
            set { _forward = value; }
        }
        public Enum backward
        {
            get { return _backward; }
            set { _backward = value; }
        }
        public Enum jump
        {
            get { return _jump; }
            set { _jump = value; }
        }
    }
}
