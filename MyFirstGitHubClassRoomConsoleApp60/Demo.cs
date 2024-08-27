using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstGitHubClassRoomConsoleApp60
{
    public class Demo
    {
        //Instanfelter
        string _name;
        int _id;
        int _alder;
        string _højde;

        //properties
        public string Name { get => _name; set => _name = value; }
        public int Id { get => _id; set => _id = value; }
        public int Alder { get => _alder; set => _alder = value; }
        public string Højde { get => _højde; set => _højde = value; }
    }
}
