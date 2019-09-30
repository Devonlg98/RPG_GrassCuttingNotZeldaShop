using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_GrassCutting
{

    enum PetType { Wolf, Fox};

    class Pet
    {

        public PetType PType;
        public void Pet()
        {
            Console.WriteLine($"You pet your {PType}");
        }
        //public class Wolf : Pet
        //{
        //    public Wolf(int v1, int v2, string v3)
        //    {
        //        this.wolfUpgrade = v1;
        //        this.wolfHunger = v2;
        //        this.wolfName = v3;
        //    }

        //    public void Pet()
        //    {
        //        Console.WriteLine($"You pet {wolfName}");
        //    }
        //}

        //public class Fox : Pet
        //{
        //    public Fox(int v1, int v2, string v3)
        //    {
        //        this.foxUpgrade = v1;
        //        this.foxHealth = v2;
        //        this.foxName = v3;
        //    }
        //    public void Pet()
        //    {
        //        Console.WriteLine($"You pet {foxName}");
        //    }
        //}
    }
}
