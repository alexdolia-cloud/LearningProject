using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public delegate void CharacterForm(string form);
    internal class FormChanger
    {
        public event CharacterForm Cat;
        public event CharacterForm Dog;

        public string Form { get; set; }

        public void CatForm(string catForm)
        {
            Form = catForm;
        }

        public void DogForm(string dogForm)
        {
            Form = dogForm;
        }
    }
}
