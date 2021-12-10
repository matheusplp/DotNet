using System;

namespace DNDIO
{
    public struct Aluno
    {
        private string _name;
        private float _note;
        
        public string Nome
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public float Note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = value;
            }
        }
    }
}