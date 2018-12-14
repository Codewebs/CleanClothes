using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraries
{
    class Personne
    {
        String name;
        String dateBirth;
        String sex;

        public Personne(String name, String dateBirth, String sex)
        {
            this.name = name;
            this.dateBirth = dateBirth;
            this.sex = sex;
        }
        //Accesseurs
        public String getName()
        {
            return name;
        }
        public String getDateBird()
        {
            return dateBirth;
        }
        public String getSex()
        {
            return sex;
        }
    }
}
